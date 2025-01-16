from lab_rk2.classes import Book, Library, BookandLibrary
from lab_rk2.data import get_books, get_libraries, get_books_and_libraries_data

def get_books_with_libraries(books, libraries, books_and_libraries):
    books_sorted = sorted(books, key=lambda b: b.title)
    result = []
    for book in books_sorted:
        library_ids = [bl.library_id for bl in books_and_libraries if bl.book_id == book.id]
        libraries_with_book = [lib.name for lib in libraries if lib.id in library_ids]
        result.append((book.title, libraries_with_book))
    return result


def get_library_book_counts(libraries, books_and_libraries):
    library_books_count = {
        lib.name: sum(1 for bl in books_and_libraries if bl.library_id == lib.id)
        for lib in libraries
    }
    return sorted(library_books_count.items(), key=lambda x: x[1], reverse=True)

def get_books_with_authors_in_and_libraries(books, libraries, books_and_libraries):
    result = []
    for book in books:
        if book.author.split()[-1].endswith("ин"):
            library_ids = [bl.library_id for bl in books_and_libraries if bl.book_id == book.id]
            libraries_with_book = [lib.name for lib in libraries if lib.id in library_ids]
            result.append((book.title, book.author, libraries_with_book))
    return result