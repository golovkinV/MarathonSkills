# Marathon Skills
Проект по предмету Программная инженерия


## Services
Описание сервисов

### 1. User Service
	
#### Описание классов:
	
  * класс *User*:
		
		email - Email пользователя;
			
		password - пароль;
			
		firstName - имя;
			
		lastName - фамилия;
			
		role - объект класса Role;
			
		runnerData - объект класса RunnerData;
    	
  * класс *Role*:
			
		roleId - id роли;
		
		name - название роли;

  * класс *RunnerData*:

		id - id участника забега;

		gender - пол;

		dateOfBirth - дата рождения;

		countryCode - код страны;
			
		country - название страны;

#### Методы:

  * ***Login(string email, string password)*** - метод для авторизации пользователя

		Параметры: 
		  email - Email пользователя;
		  password - пароль пользователя.

		Возвращает: объект класса User;
			
		Заметка: RunnerData возвращается в случае, когда пользователь авторизирован, как участник марафона 
			 (role.id = "R").
		
  * ***EditUser(User user)*** - метод для редактирования профиля
		
		Параметры:
		  user - объект класса User с обновленными значениями полей;
			 
		Возвращает: void метод;
			
		Заметка: новый объект класса User не создается, а используется тот, который был получен из метода Login.
		
  * ***RegisterAsRunner(string email, string password, string firstName, string lastName,*** 
            		***string gender, string dateOfBirth, string countryCode)*** - метод для регистрации участника марафона
			
		Параметры: 
		  email - Email пользователя;
		  password - пароль пользователя;
		  firstName - имя;	
		  lastName - фамилия;		  
		  gender - пол;
		  dateOfBirth - дата рождения;
		  countryCode - код страны;
		  
		Возвращает: объект класса User.		
		
