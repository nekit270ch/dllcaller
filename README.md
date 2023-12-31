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
- `string funcName`: название функции или ее порядковый номер с префиксом `#`.
- `DllCallerLib.Argument[] args`: массив аргументов функции.

Возвращает результат выполнения функции, приведенный к указанному типу.

`T DllCallerLib.DllCaller.CallFunction<T>(string dllName, string funcName, List<DllCallerLib.Argument[]> args)`
- `string dllName`: название или путь к DLL.
- `string funcName`: название функции или ее порядковый номер с префиксом `#`.
- `List<DllCallerLib.Argument[]> args`: массив аргументов функции.

Возвращает результат выполнения функции, приведенный к указанному типу.

`object DllCallerLib.DllCaller.CallFunction(string dllName, string funcName, string type, DllCallerLib.Argument[] args)`
- `string dllName`: название или путь к DLL.
- `string funcName`: название функции или ее порядковый номер с префиксом `#`.
- `string type`: тип результата функции.
- `DllCallerLib.Argument[] args`: массив аргументов функции.

Возвращает результат выполнения функции.

`object DllCallerLib.DllCaller.CallFunction(string dllName, string funcName, string type, List<DllCallerLib.Argument[]> args)`
- `string dllName`: название или путь к DLL.
- `string funcName`: название функции или ее порядковый номер с префиксом `#`.
- `string type`: тип результата функции.
- `List<DllCallerLib.Argument[]> args`: массив аргументов функции.

Возвращает результат выполнения функции.
