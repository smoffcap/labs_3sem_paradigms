import os
import yt_dlp
import time
import hashlib
from aiogram.types import FSInputFile

def generate_url_id(url: str):
    return hashlib.md5(url.encode()).hexdigest()

def get_available_formats(url: str):
    ydl_opts = {
        'quiet': True,
        'listformats': True,
    }
    
    with yt_dlp.YoutubeDL(ydl_opts) as ydl:
        try:
            info = ydl.extract_info(url, download=False)
            return info.get('formats', [])
        except yt_dlp.DownloadError as e:
            print(f"Ошибка при получении форматов: {e}")
            return []

async def download_and_send_media(bot, chat_id, url, media_type):
    formats = get_available_formats(url)
    if not formats:
        await bot.send_message(chat_id, "Не удалось получить доступные форматы для этого видео.")
        return

    selected_format = None
    if media_type == 'video':
        for f in formats:
            if f.get('vcodec') != 'none' and f.get('acodec') != 'none':
                selected_format = f
                break
    else:
        for f in formats:
            if f.get('ext') == 'm4a':
                selected_format = f
                break

    if not selected_format:
        await bot.send_message(chat_id, f"Не удалось найти подходящий формат для {media_type}.")
        return


    ydl_opts = {
        'format': selected_format['format_id'],
        'outtmpl': f'downloads/%(title)s.{"mp4" if media_type == "video" else "m4a"}',
    }

    try:
        start_time = time.time()

        with yt_dlp.YoutubeDL(ydl_opts) as ydl:
            info = ydl.extract_info(url, download=True)
            filename = ydl.prepare_filename(info)

        end_time = time.time()
        elapsed_time = end_time - start_time

        media_file = FSInputFile(filename)
        if media_type == "video":
            await bot.send_video(chat_id, media_file, caption=f"Держи. Видео скачано за {elapsed_time:.2f} секунд")
        else:
            await bot.send_audio(chat_id, media_file, caption=f"Держи. Аудио скачано за {elapsed_time:.2f} секунд")

        os.remove(filename)

    except Exception as e:
        await bot.send_message(chat_id, f"Произошла ошибка: {e}")
