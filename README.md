# dllcaller
Библиотека C# для динамического вызова функций из DLL

## Документация

### DllCallerLib.Argument
Класс `DllCallerLib.Argument` представляет аргумент функции.

Конструктор: `new DllCallerLib.Argument(string argType, object argValue)`
- `string argType`: полное название типа аргумента (`System.Int32`, `System.Text.StringBuilder` и т.д.)
- `object argValue`: значение аргумента.

### DllCallerLib.DllCaller
Класс `DllCallerLib.DllCaller` содержит методы непосредственно для вызова функций из DLL.

`T DllCallerLib.DllCaller.CallFunction<T>(string dllName, string funcName, DllCallerLib.Argument[] args)`
- `string dllName`: название или путь к DLL.
- `string funcName`: название функции.
- `DllCallerLib.Argument[] args`: массив аргументов функции.
Возвращает результат выполнения функции, приведенный к указанному типу.

`T DllCaller.DllCallerLib.CallFunction<T>(string dllName, string funcName, List<DllCallerLib.Argument[]> args)`
- `string dllName`: название или путь к DLL.
- `string funcName`: название функции.
- `List<DllCallerLib.Argument[]> args`: массив аргументов функции.
Возвращает результат выполнения функции, приведенный к указанному типу.
