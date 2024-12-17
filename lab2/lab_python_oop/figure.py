from abc import ABC, abstractmethod


class Figure(ABC):
    """
    Абстрактный класс «Геометрическая фигура»
    """
    @abstractmethod
    def square(self):
        """
        содержит абстрактный метод для вычисления площади фигуры.
        """
        pass