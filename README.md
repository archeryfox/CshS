# CshS
# Необходимо реализовать программу по заказу тортов для условной кондитерской в консоли
## Из функционала необходимо реализовать следующее:
  ### Выбор торта должен быть реализован из нескольких пунктов:
- форма, размер, вкус, количество, глазурь и декор. 
- Меню должно быть стрелочным
- При нажатии Enter это меню должно переходить в дополнительное меню с выбором определенного вида пункта. Внутри должно быть не менее трех пунктов.
- Должна быть возможность выхода их этого меню по нажатию клавиши Escape
- Должен быть вывод суммарной цены и суммарного заказа
- По окончанию заказа итоговый заказ и его стоимость должен быть сохранен в файл в формате, представленный в текстовом файле "История заказов" (на видео ошибка, там нет сохранения цены).
- Вместо значений, указанных в <>, должны быть значения из кода. Все заказы, сделанные в приложении, должны сохраняться в этом файле. Расположение на ваш выбор
- Должна быть возможность после оформления заказа сделать еще один заказ
 
## Из структуры кода, необходимо реализовать следующее:
- Необходимо создать отдельный класс для заказа.
  ### Внутри класса должен быть следующий функционал:
- выбор пункта основного меню, выбор пункта дополнительного меню (ОДИН МЕТОД, НЕ НЕСКОЛЬКО ДЛЯ КАЖДОГО!),
- сохранение в файл. Остальные методы по желанию. Методы внутри класса заказа должны быть как приватными, так и публичными
- Должен быть свой тип данных - подпункт меню(условно говоря, я нажимаю enter и у меня выводятся все подпункты меню. Подпункт хранит в себе описание и цену подпункта)
- Внутри подпункта меню нужно создать конструктор, чтобы из кода можно было проще создавать объект этого меню
