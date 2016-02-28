# IoCSimpleProject

The main purposes of this project are:
>	Strong knowledge of typical architecture of enterprise application;
>	Deep knowledge of IoC principles;
>	Knowledge of Castle.Windsor API specifically. 

Tasks:
•	Create simple ASP.NET MVC application;
•	Create and Register elements from figure 1.0 using Castle.Windsor container. Will be good if interfaces (contracts) will be places in appropriate and separate assemblies;
•	Dependencies should be resolved using DependencyResolver and constructor injection approach;
•	Don’t delete DependencyResolver from the project but configure MVC application to ControllerFactory instead of DependencyResolver. Need to know why ControllerFactory is better than DependencyResolver for ASP.NET MVC applications;
•	Inject UserService to BaseController using property injection;
•	Integrate container with Castle.Windsor-NLog;
•	Extend the repositories to supporting SQL database via ORM;
•	Add support “transaction per web request” feature. For this purpose custom ASP.NET MVC ActionInvoker should be used.
