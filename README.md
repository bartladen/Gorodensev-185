# 03.09.21-185 
git
git clone https://github.com/bartladen/Gorodensev-185.git
cd Gorodensev-185/
git add .
git commit -m "."
git push https://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@github.com/bartladen/Gorodensev-185.git

1 скачали OpenCV по ссылке https://opencv.org/releases/ и выбрать версию для windows
2 Создать пустой проект С++
3 Кликакем по названию проекта и кликаем на "Добавить"->Создать->Файл С++(.cpp)
4 После этого по названием проекта кликаем правой кнопкой мыши и выбираем "Свойства".Находим с/с++ -> раскрываем, находим "Общие" ->Находим каталог включаемых файлов ->указываем путь"...\opencv\build\include"
5 Далее выбираем "Компоновщики" -> "Общие" -> "Дополнительный каталоги библиотек"->указываем путь "...\opencv\build\x64\vc15\lib"
6 Во все том же "Компоновщике" находим "Ввод" - > "Дополнительные зависимости" и из папки lib выбираем opencv_world453.lib opencv_world453d.lib 
7 Всё сделанное должно быть выполнено на платформе x64
8 Из папки "...opencv\build\x64\vc15\bin копируете opencv_world453.lib opencv_world453d.lib в папку C:... source\repos\(название проекта)\Debug
9 Полностью переписываем исходный код, кроме строчки namedWindow ("Hello word",0);
10 Запускаем и получаем изображение 
