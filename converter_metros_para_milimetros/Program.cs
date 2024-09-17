import unittest
from exercicios.converter_metros_milimetros import converter_metros_para_milimetros

class TestConverterMetrosParaMilimetros(unittest.TestCase) :
    def test_converter_positivos(self):
        self.assertEqual(converter_metros_para_milimetros(1), 1000)

    def test_converter_decimais(self):
        self.assertEqual(converter_metros_para_milimetros(1.5), 1500)

if __name__ == '__main__':
    unittest.main()
