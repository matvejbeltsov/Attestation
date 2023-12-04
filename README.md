1. inizialisation_array (инициализация_массива):
* Описание: этот метод создает и инициализирует массив строк, запрашивая у пользователя ввод строковых значений.
* Параметры: принимает целочисленный параметр length_of_array, который определяет длину создаваемого массива.
* Возвращаемое значение: возвращает созданный и инициализированный массив строк.
2. print_array (печать_массива):
* Описание: этот метод выводит элементы массива на консоль в виде строки, заключенной в квадратные скобки.
* Параметры: принимает массив строк array.
- Возвращаемое значение: метод является процедурным (void), и не возвращает значения.
3. solving_the_task (решение_задачи):
- Описание: В данном случае, метод создает новый массив, содержащий только те строки из исходного массива, длина которых не превышает 3 символа.
- Параметры: принимает массив строк array.
- Возвращаемое значение: возвращает новый массив строк, содержащий строки из исходного массива, удовлетворяющие условию (длина не более 3 символов).
4. Main (главный метод):
* Это главный метод программы, который вызывает остальные методы для выполнения основной логики программы. Здесь пользователь вводит длину массива, инициализируется массив, выводится исходный массив, затем вызывается метод solving_the_problem для обработки массива, и, наконец, выводится результат.