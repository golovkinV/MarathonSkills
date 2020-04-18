# Marathon Skills
Проект по предмету Программная инженерия


## Services
Описание сервисов

1. **User Service**
	
	+Описание классов:

		1. класс User:
        
	       	* email - Email пользователя;

       		* password - пароль;

       		* firstName - имя;

	       	* lastName - фамилия;

        	* role - объект класса _Role_;

	       	* runnerData - объект класса _RunnerData_;
    	
		2. класс Role:
			
			* roleId - id роли;

			* name - название роли;

		3. класс RunnerData:

			* id - id участника забега;

			* gender - пол;

			* dateOfBirth - дата рождения;

			* countryCode - код страны;

       		* country - название страны;

	+Методы:

		1. Login(string email, string password) - метод для авторизации пользователя

			* Параметры: 
				email - Email пользователя;
				password - пароль пользователя.

			* Возвращает: объект класса _User_;
		
    		* Заметка: ***RunnerData*** возвращается в случае, когда пользователь авторизирован, как участник марафона (role.id = "R")
