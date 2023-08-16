# dllcaller
Библиотека C# для динамического вызова функций из DLL

## Документация

### DllCaller.Argument
Класс `DllCaller.Argument` представляет аргумент функции.

Конструктор: `new DllCaller.Argument(string argType, object argValue)`
- `string argType`: полное название типа аргумента (`System.Int32`, `System.Text.StringBuilder` и т.д.)
- `object argValue`: значение аргумента.

### DllCaller.DllCaller
Класс `DllCaller.DllCaller` содержит методы непосредственно для вызова функций из DLL.

`T DllCaller.DllCaller.CallFunction<T>(string dllName, string funcName, DllCaller.Argument[] args)`
- `string dllName`: название или путь к DLL.
- `string funcName`: название функции.
- `DllCaller.Argument[] args`: массив аргументов функции.
Возвращает результат выполнения функции, приведенный к указанному типу.

`T DllCaller.DllCaller.CallFunction<T>(string dllName, string funcName, List<DllCaller.Argument[]> args)`
- `string dllName`: название или путь к DLL.
- `string funcName`: название функции.
- `List<DllCaller.Argument[]> args`: массив аргументов функции.
Возвращает результат выполнения функции, приведенный к указанному типу.
