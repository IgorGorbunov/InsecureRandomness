	Безопасность криптографических систем часто зависит от некоторых данных, которые должны быть известны лишь авторизованным пользователям и которые должно быть трудно угадать злоумышленнику. Примерами таких данных могут быть сессионные ключи, инициализирующие вектора, соль, уникальные параметры в функциях ЭЦП и многие другие объекты. Чтобы достичь требуемого уровня непредсказуемости при условии частой генерации случайных чисел, требуется надёжный источник случайных чисел. К сожалению, многие криптографические приложения не обладают надежным источником случайных последовательностей значений. Вместо этого приходится использовать генераторы псевдослучайных чисел (ГПСЧ). ГПСЧ получает на вход поток данных из источника с низкой энтропией и пытается его преобразовать в последовательность значений, практически неотличимую от настоящей случайной последовательности. Успешная атака на ГПСЧ может вскрыть многие криптографические системы независимо от того, насколько тщательно они были спроектированы. Тем не менее, некоторые системы используют плохо спроектированные ГПСЧ или делают это таким образом, что уменьшает сложность атак. Более того, требуется лишь одно успешное проникновение, чтобы скомпрометировать всю систему.
	В данном проекте приведены три примера метода, возвращающие токены из псевдослучайного набора цифр. Такие токены могут использоваться для формирования различных приватных идентификаторов транзакций:
	- в классе BadSecureRandomness приведен пример небезопасного формирования токенов, основанного на стандартном ГПСЧ;
	- в классе NotGoodSecureRandomness приведен пример попытки безопасного формирования токенов, используя двойную псевдогенерацию с заданием сида. Несмотря на визуально запутанный метод формирования это не делает генератор случайным и атака на ГПСЧ все еще возможна.
	- в классе GoodSecureRandomness представлена реализация с использованием криптографически стойкого к атакам генератора ГПСЧ, что значительно снижает вероятность успешной атаки.