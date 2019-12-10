# AutoCompleter
# Документация по первому заданию(PHP)
## Задание

**XML должен иметь 2 или 3 логических измерения.**

**Файл должен содержать следующие поля:**
  - id
  - name
  - gender
  - native name
  - name in a foreign language

**Выводить таблицу на HTML при помощи php**

**Придумать 3 свои функции:**
  - Отображение первого и последнего имени
  - Отображать в таблице только мужчин или только женщин
  - Поиск имени по первой букве имени или по имени
  
## XML файл
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/3.PNG)
## Документация PHP кода

**Для начала необходимо добавить строчку для запроса XML файла**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/18.PNG)
**Эта часть кода отвечает за отображение таблицы и xml данных при помощи php**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/11.PNG)
#### Отображение первого и последнего имени

**Функции для отображения первого и последнего имени**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/12.PNG)
#### Отображение в таблице только мужчин или только женщин

**Вывод самой таблици**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/14.PNG)
**Ссылки которые передают значения для вывода**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/13.PNG)
**Php код который принимает и обрабатывает эти значения**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/17.PNG)
#### Поиск имени по первой букве имени или по имени

**Таблица которая отображает имена отсортированные по контретной букве имени или поп имени**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/16.PNG)
**Форма в которую вписывает данные пользователь для находении имени**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/15.PNG)
**Функция которая ищет конкретное имя которое ввел пользователь**
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/19.PNG)

# Документация по второму заданию(ASP.NET)
## Задание
Создать веб-сайт на основе ASP.NET. Сайт создан для просмотра разнообразных имен и их поиску с помощью сортировки. На сайте есть используется 3 роли.
## Роли

**Гость**
У гостя есть возможно просматривать добавленных пользователем или администратором имена, а также ему доступна сортировка. 

**Пользователь**
Для того чтобы стать пользователем необходимо зарегестироваться или войти в свой аккаунт, затем у пользователя появляються дополнительные возможности. В распоряжение пользователя входят такие возможности как: просмотр и добавление имен, сортировка и выход с аккаунта. 

**Администратор**
Администратор изначально прописан в базе данных, им нельзя стать. Для того что бы зайти под администартора необходимо знать логин и пароль.  У администратора самое большое количество возможностей, по мимо добавления, простомтра и сортировки имён, он также обладает возможностью изменять или даже удалять их.
## Сценарий

**Гость**

Когда гость заходит на страницу у него есть возможность увидеть все имена и отсортировать их по желанию. Также у гостя есть возможность зарегестрироваться или залогиниться.
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/1.PNG)
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/2.PNG)
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/4.PNG)

**Пользователь**

Заходя на аккаунт пользователя появляется возможность добавлять имена.
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/5.PNG)
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/6.PNG)

**Администратор**

При заходе на аккаунт администратора появляеться новая страница "Admin" на которой у администратора появляеться возможно изменять и удалять имена по мимо их добавления.
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/10.PNG)
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/7.PNG)
![](https://github.com/RaplinK/AutoCompleter/blob/master/Images/8.PNG)
