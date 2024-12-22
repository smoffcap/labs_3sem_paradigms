from aiogram import Router
from aiogram.filters import CommandStart
from aiogram.types import Message

import handlers.func as hf
import url_storage as storage
import keyboards.inline_kb as in_kb

router = Router()

@router.message(CommandStart())
async def cmd_start(message: Message):
    await message.reply("Привет! Я бот для скачивания видео из ютуба, тиктока или инстаграмма!\nОтправь мне ссылку и я всё сделаю!")

@router.message(lambda message: "tiktok.com" in message.text or "youtube.com" in message.text or "youtu.be" in message.text or "instagram.com" in message.text)
async def video_request(message: Message):
    url = message.text.strip()
    url_id = hf.generate_url_id(url)
    storage.url_storage[url_id] = url
    storage.save_url_storage(storage.url_storage)
    storage.url_storage = storage.load_url_storage()
    await message.answer("Выберите формат загрузки:", reply_markup = await in_kb.format_button(url_id))
