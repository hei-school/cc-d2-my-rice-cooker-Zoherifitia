powerOne = False
keepWarm = False  # quand cook est fini avec succes
# en g
maxWeight = 500
weight = 0
start = 0


def cook():
    global weight, powerOne, keepWarm, start
    if weight == 0:
        weight = int(input("Le poids du riz : "))
        if weight > maxWeight:
            print("Y a beaucoup trop de riz")
        else:
            input("Pour ajouter de l'eau dans le rice cooker, cliquer sur enter")
            start = input(
                "Si vous voulez faire cuire tout de suite, cliquer sur le nombre 0 sinon veuillez indiquer dans combien de minute vous voulez commencer la cuisson : ")
            if int(start) == 0:
                powerOne = True
                print("Cuisson")
            else:
                print("La cuisson commencera dans " + start + " minutes")
            keepWarm = True
            print("Maintien au chaud")
    else:
        print("Vous pouvez pas en ajouter")


def prediction():
    if 500 >= weight > 300:
        print("Votre cuisson sera finie dans " + str(45 + int(start)) + " min")
    elif 300 >= weight > 100:
        print("Votre cuisson sera finie dans "+str(30 + int(start))+" min")
    elif 0<weight <= 100:
        print("Votre cuisson sera finie dans "+str(20 + int(start))+"min")
    else:
        print("Y a même pas de riz dans le rice cooker")


option = int(input("Entrez votre choix : "))
while option != 3:
    if option == 1:
        cook()
    elif option == 2:
        prediction()
    elif option == 3:
        break
    else:
        print("Option invalide.")
    option = int(input("Entrer un autre choix : "))
