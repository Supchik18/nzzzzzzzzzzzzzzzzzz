import time
import json
import csv
from datetime import date
name=[]
orudie=[]
def textSleep(text, num):
    print(text)
    time.sleep(num)
def end():
    return f"Тогда ты мне не годишься, прощай!"
def conc():
    return "хорошая концовка"
#Список
da = ["хорошая концовка", "Плохая концовка"]

textSleep("Вы уже бывалый инквизитор, ваш меч повидал немало разных существ, таких как вампиров или даже демонов, однако несмотря н это утро у вас всегда тяжёлое", 2)
# print()
# time.sleep(3)
textSleep("Ваш товарищ, юный маг спит на койке рядом... он очень утомился после нового приключения ", 3)
print("И пока всё тихо и спокойно, вы выходите на улицу... холодный воздух бьёт вам в лицо, а ещё не сошедшая роса заставляет мурашки пробежаться по коже")
time.sleep(2)
print("Однако стоило вам повернуть свою голову в лес, вы увидели просто прекраснейшую девушку")
time.sleep(2)
print("Её локоны развиваются на ветру, а ярко-красные глазки заставляют ваше сердце биться чаще")
time.sleep(2)
print("Ваши ноги сами бегут за ней, вы пытаетесь догнать её, не замечая как удаляетесь от товарища, уворачиваясь от веток")
time.sleep(3)
print("И вы наконец находите её в чаще леса, та сидит тихо, рассчёсывая свои волосы")
time.sleep(4)
whattodo = { 1: "Что ты тут делаешь?", 2: "Кто ты такая?", 3: "Напасть без вопросов"}
print("выберите вариант ответа:1: Что ты тут делаешь? 2: Кто ты такая? 3: Напасть без вопросов ")
a = int(input())
if a == 1:
    print( "\"Я? Я тут живу, я тот кто помогает путникам, чтобы они не потерялись, но пока не об этом, какого твоё имя?\"")
    time.sleep(2)
    print("ведите своё имя:")
    time.sleep(2)
    name = input()
    time.sleep (1)
    print("\"Хорошее и славное имя:\"")
    time.sleep(1)
    print(name)
elif a==2:
    print("\"Я наблюдаю за путниками, такими как ты, мне интересно им подсказывать) Но сначала... не люблю разговаривать с теми чьего имени я не знаю... может назовёшься?\"")
    time.sleep(2)
    print("ведите своё имя:")
    time.sleep(2)
    name = input()
    time.sleep (1)
    print("Хорошее и славное имя:")
    print(name)
elif a==3:
    print("Вы пытаетесь двинуться с места, но ваши ноги не двигаются, а руки будто застыли... девушка же смеётся:" "\"Не гоже нападать на тех, кто хочет тебе помочь, какое твоё имя, инквизитор?\"")
    time.sleep(2)
    print("ведите своё имя:")
    time.sleep(2)
    name = input()
    print("Хорошее и славное имя:")
    print(name)
print("Говорит девушка, улыбаясь вам, после чего та смотрит куда то вдаль, громко вздыхая... кажется та опечалина, но чем?")
time.sleep(2)
print("\" Ты умеешь хорошо сражаться? Какое у тебя оружие?\"")
time.sleep(2)
print("Выберите своё оружие и напишите его: Одноручный меч, Клинки, топоры, Двуручный меч")
orudie = input()
time.sleep(2)
print(f"\"Прекрасно,", (orudie), "Но однако это всё же ближний бой... я больше по дальнему, однако... ты сильно боишься демонов?\"")
def save():
    name_saved = name
    orudie_saved = orudie
    save = {
        "Name":name_saved,
        "orudie":orudie_saved
    }
    with open('save.json','w+') as file:
        json.dump(save,file)
    print ("Данные сохранены")
    save()
print("Выберите ответ: 1) да 2) нет")
boish = int(input())
if boish == 1:
    print(end())
    time.sleep(2)
    print("Девушка растворяется в воздухе... кажется вы упустили что то важное... игра закончена: ")
    print (da[1])
if boish == 2:
    print("\"Это замечательно, такой как ты мне и нужен... понимаешь... в этом лесу уже давно водятся демоны... однако абсолютно недавно они выбрали себе короля\"")
    print("Девушка громко и тяжело выдыхает: \"Я могу отвести тебя туда, только прошу... помоги мне... иначе наш лес падёт \"")
    print("\" Ты ведь поможешь мне?\".... 1)да 2)нет")
    a = int(input())
    if a == 2:
        print(end())
        time.sleep(2)
        print("Вы слишком сильно боитесь... вы проиграли... ")
        print (da[1])
    if a == 1:
        print("\" Спасибо тебе большое! Тогда пойдём скорее! \" Девушка начала бежать, держа тебя за руку, приводя в выженную землю")
        time.sleep(1)
        print("Вы бежали достаточно далеко, пока не добежали до огромного поля... оно было полностью выжжено, а в середине стояло дерево из метала")
        time.sleep(2)
        print("Однако стоило вам взглянуть на это самое дерево, как девушка громко выдохнула, начиная не сильно подрагивать, а из её рта начал валить чёрный пар")
        time.sleep(1)
        print("И вскоре тело девушки падает на пол, а дерево переделывается в трон, а вот из девушки вылетает нечто, садясь на этот самый трон")
        time.sleep(1)
        print("Это был король демонов, тот громко дышал огнём, прожигая тебя огненым взглядом")
        time.sleep(1)
        print("\" Ты сам пришёл в мой дом! И сегодня ты умрёшь!\"")
        print ("\" Но сначала... как тебя зовут ещё раз, посмешище?)\"")
        time.sleep(2)
        print ("Введите имя:")
        name = input()
        time.sleep(1)
        print ("\"А твоё оружие это?\"")
        print ("Какое у вас оружие")
        orudie = input()
        time.sleep(2)
        def load():
            with open('save.json','r')as file:
                save = json.load(file)
            name_saved  = save['name']
            orudie_saved = save['orudie']
            print("Данные загружены")

        load ()
        print("Выберите действие: 1) Попытаться убежать 2) Встать в оборонительную позу 3) Попытаться атаковать демона")
        time.sleep (1)
        q = int(input())
        time.sleep (1)
        if q == 1:
            print("Вы пытаетесь убежать")
            time.sleep(1)
            print("Вы слышите громкий топот прямо за вами... вам уже не сбежать и вы это прекрасно знаете!")
            time.sleep(1)
            print("Вы чувствуете как меч демона входив в вас... Вы роняете", (orudie), "А после падаете на землю")
            time.sleep(1)
            print("Последнее что вы слышите это то как демон громко смеётся над вами, а так же последние стуки вашего сердца")
            time.sleep(1)
            print("Вы умерли... ")
            time.sleep (1)
            print (da[1])
        if q == 3:
            print("Вы пытаетесь напасть на демона, однако кажется он этого и ждал")
            time.sleep(1)
            print("Вы чувствуете как ваши шаги становятся всё более и более тяжёлыми")
            time.sleep(1)
            print("Посмотрев под ноги вы видите как огромные щупальца буквально утягивают вас вниз")
            time.sleep(1)
            print("Ваши мозги уже не воспринимают реаьлность, а ваши уши слышат лишь смех демона...")
            time.sleep(1)
            print("А вот появляетесь вы в аду, где вас будут пытать, пока вы не станите прислужником демонов")
            time.sleep(1)
            print("Вы стали марионеткой демонов... ")
            time.sleep (1)
            print (da[1])
        if q == 2:
            print("Вы защищаетесь, закрываясь оружием от демона, что налетает на вас, вы стойко держитесь, хоть и земля под вами немного вскапывается, но вы хотя бы держитесь на ногах")
            time.sleep(1)
            print("Демон громко кричит, пытаясь дотянуться до вас, однако у него не получается...")
            time.sleep(1)
            print("\"А ты не так уж и прост, инквизитор! Ну что ж, посмотрим насколько ты силён! \" кричит демон. ")
            time.sleep(1)
            print("Выберите действие: 1) Попытаться откинуть демона от себя 2) Попытаться подбить ноги демона")
            time.sleep(1)
            e = int(input())
            if e == 1:
                print("Вы не смогли откинуть демона от себя, так как он слишком большой")
                time.sleep(1)
                print("Однако вы теряете равновесие... вы падаете и демон недолго думая просто убивает вас...")
                time.sleep(1)
                print("Вы умерли... ")
                print (da[1])
                time.sleep(1)
            if e == 2:
                print("Вы сбиваете демона с ног")
                time.sleep(1)
                print("Тот падает, сразу пытаясь встать")
                time.sleep(1)
                print("но вы не даёте ему этого сделать")
                time.sleep(1)
                print("Вы держите меч прямо у него на шее")
                time.sleep(1)
                print("И вы впервые видите как демон боиться")
                time.sleep(1)
                print ("Он пытается умолять пощадить его, не убивать...")
                time.sleep (1)
                print ("Однако финальное решение кажется только за вами...")
                print("Выберите действие: 1) Убить демона 2) Пощадть демона")
                time.sleep(1)
                f = int(input())
                if f == 1:
                    print("Ваш меч вонзается в горло демона... он долго мучается, но всё же умирает")
                    time.sleep(1)
                    print(" Вы убили демона и вернулись к магу...")
                    time.sleep(1)
                    print("Тот очень рад вас видеть... вы делаете завтрак и рассказываете что произошло")
                    time.sleep(1)
                    print("Маг с превеликим интересом слушает вас, улыбаясь и даже хлопает вам")
                    time.sleep(1)
                    print("Оказывается этот демон долго мучал людей живущих неподалёку")
                    time.sleep(1)
                    print("Вы идёте в ту деревушку")
                    time.sleep(1)
                    print("В вашу честь закатили праздник")
                    time.sleep(1)
                    print (da[0])
                    time.sleep(1)
                if f == 2:
                    print("Вы щадите демона, тот почти сразу предлагает контракт")
                    time.sleep(1)
                    print ("Вы долго его читаете, пытаясь заметить подвох... однако такового не оказалось")
                    time.sleep (1)
                    print("Вы заключаете контракт с демоном и тот теперь становится вашим слугой")
                    time.sleep(1)
                    print("Возвращаясь к магу, вы видите как он боиться посмотреть на демона")
                    time.sleep(1)
                    print("Однако вскоре тот просто выдохнул и решил сначала поесть и только после поинтересоваться как это всё получилось")
                    time.sleep(1)
                    print("Тот восхваляет ваши подвиги, похлопав вам")
                    time.sleep(1)
                    print ("Вы быстро доедаете свою прекрасно приготовленную еду")
                    time.sleep (1)
                    print("После этого вы довольные идёте в деревушку рядом")
                    time.sleep(1)
                    print("Оказалось что этот демон уже давно мучал жителей этой деревни")
                    time.sleep(1)
                    print("Однако вы уверяете, что теперь всё будет хорошо")
                    time.sleep(1)
                    print("Вы заставляете демона помочь всем жителям, которым он причинил зло")
                    time.sleep(1)
                    print("Люди с радостью смотрят на то, как им помогают")
                    time.sleep(1)
                    print("Все благодарят вас, а в конце концов всё сводится к празднику")
                    time.sleep(1)
                    print("Демон начинает понимать, что добро это не всегда плохо")
                    time.sleep(1)
                    print( conc())
                    time.sleep(1)
                    def save_csv():
                        name_saved = name
                        orudie_saved = orudie
                        save = [
                            [date.today(), name_saved, orudie_saved]
                        ]
                        with open("save.csv",'w+',newline='') as file:
                             writer = csv.writer(file)
                    save_csv()
                    print ("Удаление данных")
                    with open ('nested.json', 'r') as file:
                        data = json.load (file)
                    del data ["address"]["zip"]
                    with open ('nested.json', 'w' ) as file:
                        json.dump (data, file, indent =4)

