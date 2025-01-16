def main():
    from lab_rk2.data import get_books, get_libraries, get_books_and_libraries_data
    from lab_rk2.task import (
        get_books_with_libraries,
        get_library_book_counts,
        get_books_with_authors_in_and_libraries,
    )

    books = get_books()
    libraries = get_libraries()
    books_and_libraries = get_books_and_libraries_data()

    print("Задача 1:")
    books_with_libraries = get_books_with_libraries(books, libraries, books_and_libraries)
    for title, library_list in books_with_libraries:
        print(f"Книга: {title}\n Библиотеки: {', '.join(library_list)}")

    print("\nЗадача 2:")
    library_book_counts = get_library_book_counts(libraries, books_and_libraries)
    for library, count in library_book_counts:
        print(f"Библиотека: {library}, Количество книг: {count}")

    print("\nЗадача 3:")
    books_with_authors_in = get_books_with_authors_in_and_libraries(books, libraries, books_and_libraries)
    for title, author, library_list in books_with_authors_in:
        print(f"Книга: {title}, Автор: {author}\n Библиотеки: {', '.join(library_list)}")

if __name__ == "__main__":
    main()
