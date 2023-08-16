// Разработайте класс для выполнения математических функций 
// факториал,
// возведение в степень.
// Необходимо предусмотреть защиту от некорректного ввода данных,
// а также обработку исключетельных ситуаций.
// При возникновении исключительной ситуации пользователь должен получить
// соответствующее сообщение с описанием исключительной ситуации.
// Не забывайте про принципы ООП.


using Task_5;

var askUser = new InteractionsWithUser();
var calculator = new Calculator();
bool isOn = true;

while (isOn)
{
    var operation = askUser.OperationChoose();
    if ( operation == 0)
    {
        isOn = false;
        
    }
    else if(operation == 5)
    {
        askUser.ShowResult(calculator.DoOperation(askUser.NumberAsk("Введите число: "), (Operation)operation));
    }
    else if(operation == 6){
        askUser.ShowResult(calculator.DoOperation(askUser.NumberAsk("Введите число: "), (Operation)operation, askUser.NumberAsk("Введите cтепень: ")));
    }
    else
    {
        askUser.ShowResult(calculator.DoOperation(askUser.NumberAsk("Введите первое число: "), (Operation)operation, askUser.NumberAsk("Введите второе число: ")));
    }
}