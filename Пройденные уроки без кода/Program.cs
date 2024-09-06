using System;

namespace Пройденные_уроки_без_кода
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Class, struct, enum
            */
            /*
            Console.WriteLine("ССЫЛОЧНЫЕ И ЗНАЧИМЫЕ ТИПЫ C# | СТЕК И КУЧА C# | REFERENCE AND VALUE TYPES C# | C# Уроки | # 38 \nhttps://www.youtube.com/watch?v=_RUluZNOwfY&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=51");
            Console.WriteLine();
            Console.WriteLine("ОБЛАСТЬ ВИДИМОСТИ | КОНТЕКСТ ПЕРЕМЕННОЙ | КОНФЛИКТЫ ОБЛАСТЕЙ ВИДИМОСТИ | C# Уроки | # 37 \nhttps://www.youtube.com/watch?v=FyCp19W_5d8&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=50");
            Console.WriteLine();
            Console.WriteLine("ЧТО ТАКОЕ NULL | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 39 \nhttps://www.youtube.com/watch?v=wqUiYYVZDI4&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=52");
            Console.WriteLine();
            Console.WriteLine("ОПЕРАТОР ОБЪЕДИНЕНИЯ С NULL С# | C# ?? | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 40 \n https://www.youtube.com/watch?v=mXh0ci6O6og&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=54");
            Console.WriteLine();
            Console.WriteLine("ОПЕРАТОР ПРИСВАИВАНИЯ ОБЪЕДИНЕНИЯ СО ЗНАЧЕНИЕМ NULL в C# 8 | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 41\nhttps://www.youtube.com/watch?v=Jb-dFOXrSa0&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=54");
            Console.WriteLine();
            Console.WriteLine("ОПЕРАТОР УСЛОВНОГО NULL | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 42 ?. \n https://www.youtube.com/watch?v=UwVYKGi0XJk&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=55");
            Console.WriteLine();
            Console.WriteLine("КЛЮЧЕВОЕ СЛОВО PARAMS | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ \n https://www.youtube.com/watch?v=gwYuiwelSQs&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=62");
            Console.WriteLine();
            Console.WriteLine("ЧТО ТАКОЕ РЕКУРСИЯ C# | ПЕРЕПОЛНЕНИЕ СТЕКА | СТЕК ВЫЗОВОВ | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 49 \n https://www.youtube.com/watch?v=B50p1BRyb_E&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=65");
            Console.WriteLine();
            Console.WriteLine(" Как найти сумму цифр числа | СИ ШАРП ДОМАШНИЕ ЗАДАНИЯ # 17 \n https://www.youtube.com/watch?v=c4h0FKXkWf8&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=68");
            Console.WriteLine();
            Console.WriteLine("ПРЕОБРАЗОВАНИЕ И ПРИВЕДЕНИЕ ТИПОВ В C# | Явное| Неявное | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 50 \n https://www.youtube.com/watch?v=cfoec_hRfPU&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=69");
            Console.WriteLine();
            Console.WriteLine("Что такое Nullable | Null совместимые значимые типы Nullable \n https://www.youtube.com/watch?v=jhz3Ltc09m4&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=71");
            Console.WriteLine();
            Console.WriteLine("var c# что это \n https://www.youtube.com/watch?v=vbuZkuMfQ3k&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=72");
            Console.WriteLine();
            Console.WriteLine("enum c# ЧТО ЭТО И ДЛЯ ЧЕГО НУЖНО | перечисления enum c# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 54 \n https://www.youtube.com/watch?v=lBUFlJbNq-Q&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=73");
            Console.WriteLine();
            Console.WriteLine("Что такое класс | ООП C# | Что такое объект класса | Экземпляр класса | C# Уроки | # 55 \n https://www.youtube.com/watch?v=lg_D_1KNBek&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=76");
            Console.WriteLine();
            Console.WriteLine("С# методы и классы | ООП C# и вызов метода объекта класса | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 56 \n https://www.youtube.com/watch?v=PVtmZ1YeOD8&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=75");
            Console.WriteLine();
            Console.WriteLine("Модификаторы доступа C# | РАЗНИЦА МЕЖДУ public и private в C# | ООП C# | C# УРОК | # 57 \n https://www.youtube.com/watch?v=hGJ6aq5SGSU&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=76");
            Console.WriteLine();
            Console.WriteLine(" ИНКАПСУЛЯЦИЯ C# | примеры инкапсуляции с объяснением | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 58 \n https://www.youtube.com/watch?v=C0FNqM7hsao&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=77");
            Console.WriteLine();
            Console.WriteLine(" Что такое конструктор класса c# | для чего он нужен | конструктор по умолчанию си шарп | Урок # 59 \n https://www.youtube.com/watch?v=4z9vkieAyfM&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=78");
            Console.WriteLine();
            Console.WriteLine("Перегрузка конструкторов класса в C# | Что такое перегрузка | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 60 \n https://www.youtube.com/watch?v=t7cODl_-X_U&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=79");
            Console.WriteLine();
            Console.WriteLine("Ключевое слово this c# | ООП C# | С# this в конструкторе | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 61 \n https://www.youtube.com/watch?v=OD_rUWpAuDg&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=80");
            Console.WriteLine();

            // propfull - для дыстрого создания.
            Console.WriteLine("C# свойства get set | ключевое слово value | автоматические свойства c# | ООП C# Урок | # 62\n https://www.youtube.com/watch?v=2or3h5m3VbA&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=81");
            Console.WriteLine();
            Console.WriteLine("C# статические поля класса | как работает ключевое слово static | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ # 63 \n https://www.youtube.com/watch?v=uvBeW5HIU9I&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=82");
            Console.WriteLine();
            Console.WriteLine("Статические методы C# | Статические свойства C# | как работает ключевое слово static | C# ООП | # 64 \n https://www.youtube.com/watch?v=EWMfxcnWOOo&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=83");
            Console.WriteLine();
            Console.WriteLine("Статический конструктор класса c# | как работает ключевое слово static | C# ООП | # 65 \n https://www.youtube.com/watch?v=pRc703VTDPY&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=84");
            Console.WriteLine();
            Console.WriteLine("Статический класс c# | как работает ключевое слово static | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 66 \n https://www.youtube.com/watch?v=KHJnSl9PugM&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=85");
            Console.WriteLine();
            Console.WriteLine("Методы расширения c# | extension методы c# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 67 \n https://www.youtube.com/watch?v=lH4YIgIMCBM&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=87");
            Console.WriteLine();
            Console.WriteLine("partial класс c# | частичные типы c# | partial методы c# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 68 \n https://www.youtube.com/watch?v=O3hY11e9Hnw&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=87");
            Console.WriteLine();
            Console.WriteLine("const vs readonly | c# разница между const и readonly | const и static | C# ООП | # 69\n https://www.youtube.com/watch?v=tSmY8ln4t8s&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=88");
            Console.WriteLine();
            Console.WriteLine("Синтаксис инициализации объектов класса | ООП C# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 70\n https://www.youtube.com/watch?v=UIsf7vr87Eo&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=90"); 
            Console.WriteLine();
            Console.WriteLine(" Наследование в C# | Что такое наследование в ооп | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 71 \n https://www.youtube.com/watch?v=9JaiDu6DJ-o&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=90");
            Console.WriteLine();
            Console.WriteLine("Ключевое слово base в C# | наследование и конструктор класса | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 72\n https://www.youtube.com/watch?v=wr_adG-biuc&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=91");
            Console.WriteLine();
            Console.WriteLine("Операторы as is c# | наследование и приведение типов в C# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 73 \n https://www.youtube.com/watch?v=tO7ohK6vTw4&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=92");
            Console.WriteLine();
            Console.WriteLine("Наследование в C# и модификаторы доступа | модификатор protected c# \n https://www.youtube.com/watch?v=MDcPcKltm9M&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=93");
            Console.WriteLine();
            Console.WriteLine("Полиморфизм | виртуальные методы c# | virtual override c# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 75 \n https://www.youtube.com/watch?v=xH61vpBebjw&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=95");
            Console.WriteLine();
            Console.WriteLine("Абстрактные классы | зачем нужны абстрактные методы | abstract c# \n https://www.youtube.com/watch?v=GAq9QrBvVtw&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=96");
            Console.WriteLine();
            Console.WriteLine("Интерфейсы в C# зачем нужны и как используются | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 77 \n https://www.youtube.com/watch?v=8eZy5xiildM&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=97");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Наследование интерфейсов C# | множественное наследование интерфейсов | C# ООП | # 78 \n https://www.youtube.com/watch?v=V3eZX-nDQBk&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=98");
            Console.WriteLine();
            Console.WriteLine("Интерфейсы в C# | ЯВНАЯ РЕАЛИЗАЦИЯ интерфейса C# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 79 \n https://www.youtube.com/watch?v=k9XQBLUzNQA&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=99");
            Console.WriteLine();
            Console.WriteLine("Реализация интерфейса по умолчанию в C# 8.0 | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 80\n https://www.youtube.com/watch?v=90WZfH-7Xow&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=100");
            Console.WriteLine();
            Console.WriteLine("Структуры в C# | структуры и классы отличия | struct vs class | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 81 \n https://www.youtube.com/watch?v=8E9P_lnJ7RI&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=101");
            Console.WriteLine();
            Console.WriteLine("Упаковка и распаковка значимых типов c# | boxing and unboxing | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 82 \n https://www.youtube.com/watch?v=FawYy8tztdI&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=102");
            Console.WriteLine();
            Console.WriteLine("Обобщения в C# | C# generics | generic типы методы и классы | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 83 \n https://www.youtube.com/watch?v=TLMwNFCcqVo&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=103");
            Console.WriteLine();
            Console.WriteLine("Обобщения в C# | производительность | коллекции | list vs arraylist | C# ООП | # 84 \n https://www.youtube.com/watch?v=aToq1UEKSuM&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=104");
            Console.WriteLine();
            Console.WriteLine("C# List \n https://www.youtube.com/watch?v=DcqXjL8U7wY");
            Console.WriteLine();


            */










            Console.WriteLine("SQL SQL SQL ____________________________ SQL SQL SQL");
            Console.WriteLine();


            Console.WriteLine(" Вся база SQL для начинающих за 1 час \n  Начало");
            Console.WriteLine();
            Console.WriteLine("БД \n Табилицы \n Создание таблиц");

            /*
                Создание таблиц
                CREATE TABLE "nameTable" (какие колонки для таблиц будут созданы. Есть свои типы,  примеру BIGINT - только целые числа)

                Запись новых данных
                INSERT INTO "nameTable" - Записать в "название таблицы" (колонки)
                VALUES (присваивание данных в колонки, очередность данных должны совпадать с выше перечисленными данными.)

                Обновление данных в таблицу
                UPDATE "nameTable" SET 
                "название поля для обновления" =  "значение"
                WHERE id = 1  — Условие по которому будет проходить обновление.

                DELETE FROM "nameTable" 
                WHERE id = 1 OR id = 2 — Где WHERE это условие, а OR - означает "И", удалить элементы под номером  1 и 2
            */

            /*
            
            SELECT - Для полученя данных.

            select top 100 *  from tasks  -- * Все колонки || top 100 - вывод первых 100 результатов
            AND || OR 
            Where  Id = 141667 and UserId = 4241367

            order by id desc;

            Для связки данные между таблицами необходимо в таблице которая будет привезываться, создать новую колонку, которая будет связана с основной, например UserId
            Название: Отношение, внешний ключ

            CONSTRAINT user_id_fk  FOREING KEY (UserId)  REFERENCES nameTable (id)
            ограничение + название + указзатель на создание ключа + (какая колонка, будет привязана) - ссылаться на - имя таблица - (на какую колонку ссылаться)
             

            JOIN - соеденение колонок из двух разных таблиц

            SELECT nameTable. * , users.firstName FROM nameTable  -- nameTable. *  в данном случаи получаем все колонки из таблицы nameTable, users.firstName -- только колонку firstName из таблицы users
            JOIN users ON user.id = nameTable.user_id
            Соеденить || Какую именно таблицу мы хотим присоеденить || определение условий для соедениения таблицы || Имя таблицы к которой мы будет присоедеть к основной "." имя колонки по которой мы делаем соеденение ||  = имя таблицы к которой мы присоеденяем "." имя колонки по которой мы делаем соедение
            
            По умолчанию, только совпадения
            IINER JOIN
            Вывод всех элементов даже если не подошли по выборке.
            RIGT OUTER JOIN - с правой таблицы
            LEFT OUTER JOIN - с левой таблицы

            FULL OUTER JOIN
             

            Агригатные функции

            Пример Общая сумма

            SELECT SUN(price) FROM nameTable

            Агрегатные функции
            GROUP BY - одна логика выполнения, но по индетификатору. Результатом будет выполненная логика для каждого индетификатора. К примеру по каждому пользователю, высчитаывать его данные.


            HAVING - определяющее условия фильтрации с использованием агрегатных функций в выражениях

            ALTER TABLE - Конструкция, позволяющая определять дополнительные команды лоя изменения любых ранее созданных таблиц в БД



            Изучения данных для начала работы разработчиком (не программирование)

             */


            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine();
            // Console.WriteLine(" \n");
            Console.WriteLine();
            // Console.WriteLine(" \n");
            Console.WriteLine();
            Console.WriteLine(" Road map \n https://uproger.com/dorozhnaya-karta-razrabotchikov-net-v-2024-godu-dlya-nachinayushhih/");


        }
    }
}
