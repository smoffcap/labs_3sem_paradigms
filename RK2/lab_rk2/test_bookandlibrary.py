import unittest
from lab_rk2.data import get_books, get_libraries, get_books_and_libraries_data
from lab_rk2.task import (
    get_books_with_libraries,
    get_library_book_counts,
    get_books_with_authors_in_and_libraries,
)

class TestLibraryManagement(unittest.TestCase):

    def setUp(self):
        self.books = get_books()
        self.libraries = get_libraries()
        self.books_and_libraries = get_books_and_libraries_data()

    def test_get_books_with_libraries(self):
        result = get_books_with_libraries(self.books, self.libraries, self.books_and_libraries)
        self.assertTrue(any(book[0] == "Краткая история времени" for book in result))
        book_libraries = next(book[1] for book in result if book[0] == "Краткая история времени")
        self.assertIn("Центральная городская публичная библиотека имени В. В. Маяковского", book_libraries)

    def test_get_library_book_counts(self):
        result = get_library_book_counts(self.libraries, self.books_and_libraries)
        self.assertGreater(result[0][1], 0)
        self.assertEqual(len(result), len(self.libraries))

    def test_get_books_with_authors_in_and_libraries(self):
        result = get_books_with_authors_in_and_libraries(self.books, self.libraries, self.books_and_libraries)
        self.assertTrue(any(book[1].endswith("ин") for book in result))
        self.assertGreater(len(result), 0)

if __name__ == "__main__":
    unittest.main()

#python -m unittest discover -s lab_rk2 -p "test_bookandlibrary.py"