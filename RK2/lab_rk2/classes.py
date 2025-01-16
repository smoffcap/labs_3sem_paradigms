class Book:
    def __init__(self, id, title, author, genre, size, publisher):
        self.id = id
        self.title = title
        self.author = author
        self.genre = genre
        self.size = size
        self.publisher = publisher

class Library:
    def __init__(self, id, name, address, type, num_readrooms, contact_number, contact_email):
        self.id = id
        self.name = name
        self.address = address
        self.type = type
        self.num_readrooms = num_readrooms
        self.contact_number = contact_number
        self.contact_email = contact_email

class BookandLibrary:
    def __init__(self, book_id, library_id):
        self.book_id = book_id
        self.library_id = library_id
