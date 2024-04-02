# HorrorGame
# Как работать с гитом
## Очень важно, гит может ругаться, если у вас рабочий стол подписан-написан на русском языке
Перейти по ссылке и скачать Git: https://git-scm.com/downloads

git status

Команда git status показывает состояния файлов в рабочей директории и индексе: какие файлы изменены, но не добавлены в индекс; какие ожидают коммита в индексе. Вдобавок к этому выводятся подсказки о том, как изменить состояние файлов.

git add

Команда git add добавляет содержимое рабочей директории в индекс (staging area) для последующего коммита. По умолчанию git commit использует лишь этот индекс, так что вы можете использовать git add для сборки слепка вашего следующего коммита.

git commit

Команда git commit берёт все данные, добавленные в индекс с помощью git add, и сохраняет их слепок во внутренней базе данных, а затем сдвигает указатель текущей ветки на этот слепок.

git branch

Команда git branch — это своего рода “менеджер веток”. Она умеет перечислять ваши ветки, создавать новые, удалять и переименовывать их.

git checkout

Команда git checkout используется для переключения веток и выгрузки их содержимого в рабочую директорию.
Команда git merge используется для слияния одной или нескольких веток в текущую. Затем она устанавливает указатель текущей ветки на результирующий коммит.

## Как работать?

1. Создать локальную папку на вашем рабочем устройсте
2. Зайти в репозитории во вкладку CODE и скопировать ссылку репозитория
3. В любом IDE, заходите в папку, открываете терминал IDE и прописываете команду git clone ... (вместо точек вставить ссылку)
4. Перейти в папку репозитория, также с терминала
5. Проверить командой git status, что всё хорошо
6. Переходите в папку, создаёте ветку
7. Создали ветку и начали что-то добавлять в папке или даже менять в файле программы. Прописываем git add ..., потом git commit " ", git push 

## Каждый работает в своей ветке, то есть вы делаете merge только в вашу ветвь !!!
## Потом уже, как вы сделаете коммит и пуш, я апрувну. 
##Пишите каждый раз подробные комментарии
