# Mvc4EF_HelloPerson

ASP.NET Framework 4.5 + razor + MVC4 + MSSQL + EntityFramework. 
На главной странице вывести 3 поля FirstName, LastName, MiddleName (из модели Person сервера) и кнопку SEND 
при нажатии на кнопку Модель формы должна отправиться на сервер с помощью ajax запроса (jQuery), 
сервер должен принять запрос, сохранить модель в БД (БД: 1 таблица с 3 полями соответственно) 
и в ответе отдать эту же модель, на клиенте мы должны принять ответ и вывести обычный Alert с текстом "Hello "+ Person.FirstName

Requirements:

Visual Studio
SQL Server 2012 Express LocalDB (to run locally)

