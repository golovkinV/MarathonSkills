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
			
		runnerData - объект класса RunnerData.
    	
  * класс *Role*:
			
		roleId - id роли;
		
		name - название роли.

  * класс *RunnerData*:

		id - id участника забега;

		gender - пол;

		dateOfBirth - дата рождения;

		countryCode - код страны;
			
		country - название страны.

#### Методы сервиса:

  * ***Login(string email, string password)*** - метод для авторизации пользователя

		Параметры: 
		  email - Email пользователя;
		  password - пароль пользователя.

		Возвращает: объект класса User.
			
		Заметка: RunnerData возвращается в случае, когда пользователь авторизирован, как участник марафона 
			 (role.id = "R").
		
  * ***EditUser(User user)*** - метод для редактирования профиля
		
		Параметры:
		  user - объект класса User с обновленными значениями полей.
			 
		Возвращает: void метод.
			
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
		  countryCode - код страны.
		  
		Возвращает: void метод.	
		
### 2. Runner Service

#### Описание классов:
	
  * класс *Sponsor*:
		
		id - id спонсора;
			
		registrationId - id регистрации участника забега;
			
		name - имя спонсора;
			
		amount - сумма;
			
		charityId - id благотворительного события.
			
  * класс *Charity*:
		
		id - id спонсора;
			
		name - название благотворительного события;
			
		desc - описание;
			
		logo - логотип.

  * класс *RaceInfo*:
		
		country - страна забега;
			
		eventName - название забега;
			
		year - год;
			
		time - время преодоления дистанции;
		
		gender - пол;
		
		userDateOfBirth - дата рождения участника забега.
		
#### Методы сервиса:

  * ***GetSponsorship(int runnerId)*** - метод для получения списка спонсоров участника марафона

		Параметры: 
		  runnerId - id участника марафона.

		Возвращает: List<Sponsor>.
		
  * ***GetCharity(int charityId)*** - метод для получения благотворительного события

		Параметры: 
		  charityId - id благотворительного события.

		Возвращает: объект класса Charity.
		
  * ***GetRaces(int runnerId)*** - метод для получения информации о предыдущих забегах участника марафона

		Параметры: 
		  runnerId - id участника марафона.

		Возвращает: List<RaceInfo>.

### 3. Admin Service

#### Описание классов:
				
  * класс *Charity*:
		
		id - id спонсора;
			
		name - название благотворительного события;
			
		desc - описание;
			
		logo - логотип.

  * класс *Volunteer*:
  
  		firstName - имя;
			
		lastName - фамилия;
			
		countryCode - код страны;
			
		gender - пол.

  * класс *User*:
		
		email - Email пользователя;
			
		password - пароль;
			
		firstName - имя;
			
		lastName - фамилия;
			
		role - объект класса Role;
			
		runnerData - объект класса RunnerData.

#### Методы сервиса:

  * ***GetAllCharity()*** - метод для получения списка благотворительных фондов 

		Возвращает: List<Charity>.
		
  * ***EditCharity(Charity charity)*** - метод для редактирования благотворительного фонда 

		Параметры: 
		  charity - объект класса Charity.

		Возвращает: void метод.
		
  * ***AddCharity(string name, string desc, string logo)*** - метод для добавления благотворительного фонда 

		Параметры: 
		  name - название;
		  desc - описание;
		  logo - логотип;

		Возвращает: void метод.

  * ***AddVolunteers(List<Volunteer> volunteers)*** - метод для импорта списка волонтеров

		Параметры: 
		  volunteers - список волонтеров;

		Возвращает: void метод.
		
  * ***GetAllUser()*** - метод для получения всех пользователей

		Возвращает: List<User>.

  * ***EditUser(User user)*** - метод для редактирования пользователя

		Параметры: 
		  user - объект класса User.

		Возвращает: void метод.

  * ***AddUser(string email, string password, string firstName, string lastName, string roleId)*** - метод для добавления пользователя

		Параметры: 
		  email - Email пользователя;
		  password - пароль пользователя;
		  firstName - имя;
		  lastName - фамилия;
		  roleId - id роли пользователя в системе

		Возвращает: void метод.

### 4. Coordinator Service

#### Описание классов:
				
  * класс *Charity*:
		
		id - id спонсора;
			
		name - название благотворительного события;
			
		desc - описание;
			
		logo - логотип.

  * класс *User*:
		
		email - Email пользователя;
			
		password - пароль;
			
		firstName - имя;
			
		lastName - фамилия;
			
		role - объект класса Role;
			
		runnerData - объект класса RunnerData.

  * класс *Country*:
		
		code - код страны;
			
		name - название.

  * класс *RegistrationStatus*:
		
		id - id статуса;
			
		name - название;
		
		registrationId - статус регистрации пользователя 

#### Методы сервиса:

  * ***GetAllRunners()*** - метод для получения всех участников забегов

		Возвращает: List<User>.
		
  * ***EditUser(User user)*** - метод для редактирования пользователя

		Параметры: 
		  user - объект класса User.

		Возвращает: void метод.
		
  * ***GetCountries()*** - метод для получения списка стран

		Возвращает: List<Country>.
		
  * ***GetRegistrationStatuses()*** - метод для получения списка статусов

		Возвращает: List<RegistrationStatus>.

  * ***GetAllCharity()*** - метод для получения списка благотворительных фондов 

		Возвращает: List<Charity>.

### 5. Sponsor Service

#### Описание классов:
				
  * класс *Runner*:
		
		id - id участника;
			
		registrationId - статус регистрации;
			
		firstName - имя;
			
		lastName - фамилия;
		
		country - код страны;
		
		sponsorshipTarget - спонсорская поддержка;
		
		charity - объект класса Charity
		
#### Методы сервиса:

  * ***GetRunners()*** - метод для получения всех участников забегов

		Возвращает: List<Runner>.
		
  * ***SponsorRunner(string name, Runner runner, double amount)*** - метод для спонсирования участника забега

		Параметры: 
		  name - имя спонсора;
		  runner - участник забега;
		  amount - сумма спонсирования.

		Возвращает: void метод.

### 6. Info Service

#### Описание классов:
				
  * класс *RaceResult*:
		
		runnerName - имя участника забега;
			
		country - код страны;
			
		raceTime - время забега;
			
		gender - пол;
		
		marathonId - id марафона;
		
		eventTypeId - id события марафона;
		
		dateOfBirth - дата рождения.

  * класс *Charity*:
		
		id - id спонсора;
			
		name - название благотворительного события;
			
		desc - описание;
			
		logo - логотип.

  * класс *Marathon*:
		
		id - id марафона;
			
		name - название марафона;
			
		cityName - город проведения;
			
		country - страна;
		
		year - год.
		
#### Методы сервиса:

  * ***GetRaces()*** - метод для получения списка забегов

		Возвращает: List<RaceResult>.
		
  * ***GetCharities()*** - метод для получения списка благотворительных фондов 

		Возвращает: List<Charity>.

  * ***GetMarathons()*** - метод для получения списка марафонов 

		Возвращает: List<Marathon>.

  * ***GetEventTypes()*** - метод для получения списка событий марафона

		Возвращает: List<EventType>.
