### Репозиторий "Mars"

<p align="center">
  <img src="https://github.com/FeerSSQ/Mars/assets/114866823/03bb583f-2f10-4af4-bad9-a2e058b91052" alt="Mars Logo" width="400">
</p>



---

#### Описание

Репозиторий содержит исходный код информационной системы (ИС) для автоматизации работы кафе. ИС разработана для эффективного управления заведениями общественного питания, такими как кафе. Основной функционал системы включает в себя учет заказов клиентов, управление персоналом и формирование отчетов.

---

#### Предметная область

ИС предназначена для использования сотрудниками кафе и включает в себя следующие роли:

- Администраторы
- Официанты
- Повара

---

#### Функционал

##### Общие функции для всех пользователей:

1. **Авторизация:**
   - Администратор, официант и повар должны пройти авторизацию перед получением доступа к функционалу системы.

##### Функционал администратора:

1. **Управление пользователями:**
   - Регистрация новых пользователей (официанты, повара).
   - Перевод пользователей в статус "уволен".

2. **Управление сменами:**
   - Назначение официантов и поваров на смены.
   - Назначение официантов на обслуживание конкретных мест (столиков).

3. **Управление заказами:**
   - Просмотр всех заказов.
   - Редактирование неоплаченных заказов.
   - Создание отчета о заказах, полученных от клиентов.
   - Создание отчета о заказах, оплаченных клиентами (отчет о выручке).

4. **Отчеты:**
   - Формирование отчета о всех заказах за смену (PDF и XLSX).
   - Формирование отчета об оплаченных заказах в рамках активной смены (PDF и XLSX).

##### Функционал повара:

1. **Управление заказами:**
   - Просмотр заказов, принятых от клиентов.
   - Изменение статуса заказа (готовится, готов).

##### Функционал официанта:

1. **Управление заказами:**
   - Создание нового заказа.
   - Просмотр всех принятых заказов за смену.
   - Изменение статуса заказа (принят, оплачен).

2. **Управление приходно-кассовым ордером:**
   - Создание приходно-кассового ордера с указанием способа оплаты заказа (наличная, безналичная).

3. **Отчеты:**
   - Формирование отчета о принятых заказах в период одной смены (в отдельном окне).

---

#### Интерфейсы системы

1. **Окно администратора:**
   - Список всех сотрудников, заказов, смен, формирование отчетов.
   - Возможность перехода в личную карточку сотрудника и карточку заказа.

2. **Окно повара:**
   - Перечень всех принятых от клиентов заказов.
   - Возможность перехода в карточку конкретного заказа.

3. **Окно официанта:**
   - Перечень всех заказов за период активной смены.
   - Возможность создания нового заказа и управления заказами.

---

#### Дополнительные требования:

1. **Личные карточки сотрудников:**
   - Возможность добавления фотографии и скана трудового договора через кнопку "Добавить" или перетаскивание файла.
   - Создание новых личных карточек для сотрудников.

2. **Управление сменами:**
   - Возможность формирования новых смен на 5 дней вперед от актуальной даты.
   - Общее количество сотрудников в одной смене от 4 до 7 человек.

3. **Отчеты:**
   - Возможность выбора пути сохранения файла отчета в проводнике.

---

### Инструкции по установке и запуску

...

---

### Скриншоты

![Скриншот интерфейса администратора](screenshots/admin_interface.png)

![Скриншот интерфейса повара](screenshots/chef_interface.png)

![Скриншот интерфейса официанта](screenshots/waiter_interface.png)

---

### Лицензия

Этот проект лицензирован под [MIT Лицензией](LICENSE).
