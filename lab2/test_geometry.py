import unittest
from lab_python_oop.rectangle import Rectangle
from lab_python_oop.square import Square
from lab_python_oop.color import FigureColor

class TestGeometry(unittest.TestCase):

    def test_rectangle_creation(self):
        # Создание прямоугольника
        rectangle = Rectangle("красного", 5, 10)
        self.assertEqual(rectangle.width, 5)
        self.assertEqual(rectangle.height, 10)
        self.assertEqual(rectangle.fc.colorproperty, "красного")
        self.assertEqual(rectangle.square(), 50)

    def test_square_creation(self):
        # Создание квадрата
        square = Square("синего", 5)
        self.assertEqual(square.side, 5)
        self.assertEqual(square.fc.colorproperty, "синего")
        self.assertEqual(square.square(), 25)

    def test_figure_repr(self):
        # Проверка метода __repr__ для прямоугольника
        rectangle = Rectangle("зеленого", 3, 6)
        expected_repr = "Прямоугольник зеленого цвета шириной 3 и высотой 6 площадью 18."
        self.assertEqual(rectangle.__repr__(), expected_repr)
        # Проверка метода __repr__ для квадрата
        square = Square("красного", 4)
        expected_repr = "Квадрат красного цвета со стороной 4 площадью 16."
        self.assertEqual(square.__repr__(), expected_repr)

    def test_color_setting(self):
        # Проверка установки цвета через FigureColor
        fc = FigureColor()
        fc.colorproperty = "оранжевого"
        self.assertEqual(fc.colorproperty, "оранжевого")
    
    def test_square_sq(self):
        # Проверка вычисления площади квадрата
        square = Square("фиолетового", 6)
        self.assertEqual(square.square(), 36)

    def test_rectangle_sq(self):
        # Проверка вычисления площади прямоугольника
        rectangle = Rectangle("голубого", 4, 8)
        self.assertEqual(rectangle.square(), 32)


if __name__ == '__main__':
    unittest.main()