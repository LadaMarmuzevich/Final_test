# 1. Блок-схема для программы
![Изображение блок-схемы](diagram.jpg)
# 2. Текстовое описание решения

1. Пользователю предлагается ввести элементы массива через запятую.
2. Ввод пользователя сохраняется в массиве **inputArray**.
3. Далее вызывается метод **FilterArray**, который проходит по всем элементам в **inputArray** и подсчитывает количество элементов, удовлетворяющих условию (длина не более 3 символов).
4. Создается новый массив **newArray** нужного размера, и затем снова проходится по **inputArray**, добавляя подходящие элементы в **newArray**.
5. Результат выводится в виде массива, содержащего нужные элементы.
