# Laba5TheTask
Задание 1

Пользователь вводит число. Если это целочисленное число (int.TryParse(...)), то вывести на экран символ соответствующий этому числу. Если это число с плавающей запятой, то сравнить это число с предыдущим введенным (float.NaN). Если эти числа равны, прекратить ввод, иначе повторить ввод. Также выполнение программы прекращается, если ввести символ q.

Задание 2

Пользователь вводит целочисленное число (оно может быть как положительным, так и отрицательным). Нужно проверить, что число корректно без использования любого стороннего преобразования строки в число, т.е. нельзя использовать int.Parse(), int.TryParse(), Convert.ToInt() и т.д.. Если нет, то вывести сообщение и завершить программу. Если корретно, то опять же без вызова сторонних методов и без конвертирования строки в число найти сумму цифр введенного числа.

Задание 3

Проанализировать написанный код первой лабораторной. Если требуется, то разбить программу на методы. Далее во всех лабораторных нужно  разбивать алгоритм на отдельные составляющие - методы. Ну или хотя бы пытаться. В дальнейшем (через какое-то время) за ошибки в разбиении на методы будут сниматься баллы.

Задание 4

Пользователь вводит массив. Числа могут быть положительными, отрицательными, целыми или дробными. Без изменения оригинального массива заменить все положительные целые числа в массиве на их факториал. Отрицательные целые числа оставить без изменений. Любое дробное число заменить на его дробную часть с откинутой целой частью, округленную до сотых. Например, если число равно -12.067, то его нужно заменить на число 7 (округлили число -12.067 до сотых - получили -12.07, откинули целую часть - получили 7).
Вывести для сравнения оригинальный массив, который не должен был поменяться, и результирующий массив.
