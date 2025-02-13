﻿## Содержание
 
 [1 Введение](#введение)
 
 [1.1 Описание прдметной области](#Описание)
 
 [1.2 Описание процесса покупки в магазине](#Описание)
 
 [1.3 Проблематика предметной области](#Проблематика)
 
 [2 Сравнительный анализ существующих решений](#Сравнительный_анализ)
 
 [3 Разработка](#разработка)
 
 [3.1 Этап реализации](#реализация)
 
 ## 1 Введение <a name="введение"></a>

**Цветочный Магазин**

Цветы являются неотъемлемый атрибутом какого-либо торжества или просто подарка. Актуальность их сохранилась и по сей день. Большинство праздников, торжеств нельзя представить без них. Цветы доставляют людям эстетическое удовольствие. Примечательно то, что подобный бизнес не требует значительных вложений средств. На данный момент особую популярность приобретают онлайн – магазины, связанно это с тем, что людям гораздо удобнее взять свой телефон или компьютер и воспользоваться интернет-сервисами для совершения покупок различных товаров и цветы в том числе. Магазин работает в  виде онлайн магазина.

В магазине будут предоставлены различные услуги покупателям такие как: Покупка готового букета, возможность собрать свой букет, выбрать декор для букета и доставка его заказчику.

## 1.1 Описание предметной области <a name="Описание"></a>

Диаграмма прецедентов отражающая отношения между акторами и прецедентами
На этой диаграмме можно выделить следующие объекты:

- Заказчик который делает заказ, получает, оплачивает его и взаимодействует с курьером

- Курьер, который доставляет заказ

- Кладовщик который сообщает о наличии товара, делает заказ на новую поставку и проверяет наличие товара 

Все эти отношения показаны на рисунке 1 

![image](https://user-images.githubusercontent.com/105597940/200940883-876e5fd3-3f99-4f19-aa09-41d148be0107.png)

### <p align="center">Рисунок 1 - Use case модель

## 1.2 Описание процесса покупки в магазине <a name="Описание"></a>
 
 BPMN - это язык моделирования бизнес-процессов, который является промежуточным звеном между формализацией/визуализацией и воплощением бизнес-процесса. С помощью моделирования можно описать любые бизнес-процессы, и эти процессы могут выполняться в самых разных системах управления.
 
Когда клиент заходит на сайт магазина , ему предоставляется выбрать нужную ему услугу (Купить готовый букет или собрать свой букет). Далее отправляется запрос кладовщику, который должен проверить наличие конкретного товара который выбрал клиент. Если товара нет в наличии , то клиенту предлагается дождаться наличие товара, после чего будет возможность совершить заказ. Далее предлагается выбор оплаты заказа (Оплата картой или оплата при получении) и выбор доставки (Доставка курьером или самовызов).Во время доставки заказ передаётся курьеру, который должен в целостности и сохранности доставить товар покупателю в короткий срок. Так же клиент может прийти сам в магазин и забрать свой заказ.

Весь процесс описан на рисунке 2 и 3

![Безымянный 1 (2)](https://user-images.githubusercontent.com/105597940/200934762-ecc5d71c-ecf7-4b1e-9660-bad4cda44e22.png)

### <p align="center">Рисунок 2 - BPMN модель 

![image](https://user-images.githubusercontent.com/105597940/207697143-f015c996-db66-44e1-808e-152a67c1b941.png)
### <p align="center">Рисунок 3 - Erd uml модель 

## 1.3 Проблематика предметной области <a name="Проблематика"></a>
Учет в магазине цветов – дело трудоемкое ввиду того, что цветы относятся к товару скоропортящемуся. Многие предприниматели на старте бизнеса предпочитают экономить на автоматизации торговых процессов. Например, владельцы магазинов ведут учёт по старинке – в журналах или таблицах Excel. Но работая без автоматизации, владельцы рискуют столкнуться со следующими проблемами:
 
### 1.3.1 Отсутствие понимания, какое количество товаров имеет магазин. 
 
Если учёт не автоматизирован, продавец должен записывать все продажи вручную. Из этого может выйти путаница: к примеру, из-за большого наплыва людей продавец не успеет вовремя сделать запись в журнале. Или при учёте сотрудник может допустить ошибку: составить букет из одних цветов, а отразить в тетради другие.
 
### 1.3.2 Ручной контроль.
 
Большая часть времени будет уходить на постоянное отслеживание за точным количеством проданных цветов, товарных остатков в магазине.
 
 ### 1.3.3 Невозможен рост бизнеса.
 
 Без автоматизации магазину проблематично увеличить прибыль: предприниматель не сможет грамотно прогнозировать продажи, выстраивать аналитику
 
 ### 1.3.4 Недобросовестный персонал.
 
Риск обмана со стороны продавцов будет присутствовать всегда. Например, без автоматизированной учётной системы продавцы могут продать букет без применения кассы, чтобы забрать деньги себе.
 
## 2 Сравнительный анализ существующих решений <a name="Сравнительный_анализ"></a>

Существует множетство ИС для выполнения выше перечисленных проблем. В качестве доказательства, можно привести 3 примера:



### 2.1 Касса Розница.
 
 - Программа автоматически считает остатки товаров после продаж, списаний и оприходований. Продавцу не нужно будет пересчитывать продукцию в ручном режиме и записывать данные в журнал или Excel;
 
 - Готовая номенклатура – экономия времени. Иногда кассирам приходится вбивать вручную длинные позиции. Чтобы этого избежать, в программе можно завести номенклатуру и выбирать её из списка при продаже;
 
 - В кассовой программе доступна карточка товара с ценой – продавец не перепутает ценники и не ошибётся со стоимостью конкретных цветов. Чтобы пробить товар правильно, достаточно отсканировать штрихкод или найти позицию в приложении, набрав первые буквы номенклатуры в поиске;
 
 - Работа с программой лояльности, скидками, инвентаризацией и списаниями. Свежесрезанные цветы – скоропортящийся товар. К примеру, чтобы провести операцию по списанию флоры, не нужно вносить данные в тетрадь или Excel. Списание также учитывается в программе;
 
 - Современная кассовая программа поддерживает все виды приёма платежей. Наличными платить долго: покупателю нужно посчитать сумму, а после – пересчитать продавцу, вернуть сдачу. Если покупатель даёт крупную купюру, сдачи и вовсе может не оказаться в кассе. Оплата по карте или системе быстрых платежей (СБП) происходит быстро – без времени на пересчёт и отсчитывание сдачи;
 
 - Автоматизированная аналитика. В цветочном бизнесе сезонность – одно из главных условий успешных продаж. С помощью грамотной аналитики можно отследить, в какие месяцы продаж больше, а в какие меньше всего, чтобы заранее спланировать закупки и продажи;
Ведение партийного учёта. Закупая цветы партиями, в кассовой программе возможно отразить партийный учёт товаров.
 
### Доставка цветов
 
 - Зачастую владельцы цветочного бизнеса занимаются доставкой самостоятельно – это помогает сэкономить на дополнительных расходах на курьерских службах доставки. В экосистеме «БИФИТ Бизнес» есть оптимальное решение: бесплатное мобильное приложение «Касса Курьер». Тарификация рассчитывается по количеству онлайн-заказов.
 
 - При помощи "Касса Курьер" можно получать, редактировать и оффлайн-работать с заказами. Получать информацию о позициях, клиенте и адресе доставки. Построение маршрута и выполнение звонка прямо из приложения. Создание собственных статусов выполнения заказа.
 
   
### 2.2 Posiflora
 
Простая CRM-система для учета и контроля в цветочном бизнесе. Подходит как маленьким цветочным магазинам, так и цветочным супермаркетам и даже крупным интернет-магазинам. Программа для автоматизации работы в цветочном бизнесе. Подходит как маленьким флористическим салонам, так и крупным торговым сетям.

 - Рабочее место сотрудника. Специалисты магазина могут заранее собирать букеты и размещать их на онлайн-витрине, продавая в один клик. Система отслеживает заказы на каждом этапе (новый заказ, готовый заказ, доставка). Как только в CRM поступит новый заказ, система мгновенно уведомит об этом сотрудника. 
 
 - Контроль продаж. Вы всегда видите подробную информацию о состоянии бизнеса: количество денег в кассе, выручку и другие финансовые показатели за разные периоды времени и т.п. CRM собирает статистику по каждому флористу, позволяя отслеживать их эффективность. Также вы всегда будете в курсе самых востребованных цветов, букетов и постоянных клиентов. 
 
 - Склад. Posiflora отслеживает остатки цветов на складе и позволяет своевременно планировать закупки. Синхронизация с интернет-магазином обеспечивает обновление данных на складе при продаже через сайт.

### 2.3 Florist.inspiro.pro
 
Система управления салоном цветов. Облачное решение, не требующее установки каких-либо программ или устройств.

 - Клиенты и CRM. В Inspiro вы можете создавать карточки клиентов со всей информацией о них (заказы, бонусный счет, предпочтения и пр.). Система хранит всю переписку с клиентом, позволяет связываться с ними по телефону, отправлять уведомления и т.д. Также вы можете осуществлять SMS- и email-рассылки.
 
 - Скидки и бонусы. Существует возможность создавать различные дисконтные программы – системы накопительных скидок, персональных скидок, скидок на группы клиентов или товары. Можно реализовать накопительную бонусную систему, позволяющую клиентам расплачиваться бонусами за покупки. Также можно проводить акции, дарить подарки при определенных условиях и распространять промокоды.
 
 - Витрина букетов. Практичная витрина позволяет продавать клиентам готовые букеты в кратчайшие сроки.
 
 - Склад. Система позволяет проводить закупки, списания, инвентаризацию. Адаптация под цветочные магазины поможет посчитать остатки за считанные минуты.
 
 - Учет и аналитика. Inspiro фиксирует всю информацию по бизнесу – средний чек, маржинальный доход, долю списаний, продажи постоянным клиентами и многое другое. 
 
 ### Таблица сравнений
 
 Таблица представлена на рисунке 4.
 
 ![image](https://user-images.githubusercontent.com/105597940/207666625-db45bb5b-75cc-4b97-9554-d54f6f8c92b9.png)
### <p align="center">Рисунок 4 - Таблица сравнений
 
## 3 Разработка <a name="разработка"></a>

На основе на данных IDEF, BPMN И USE CASE моделях. Эти потребуются для конкретного описания каждого созданного класса. В разработке информационной системы есть два этапа: 1 Проектирование - что представленно на IDEF, BPMN и USE CASE моделях, 2 Реализация - что представляет собой готовый программный продукт с описанием его составляющих и текстом программного кода.
 
## 3.1 Этап реализации <a name="реализация"></a>
 
В среде C# на основании модели IDEF создаем классы для каждой сущности. Ниже представлен пример создания класса Client (Рисунок 4)
 
![image](https://user-images.githubusercontent.com/105597940/203847542-630d1576-8304-4707-9c29-b07060e06084.png)
### <p align="center">Рисунок 4 - Класс Client








