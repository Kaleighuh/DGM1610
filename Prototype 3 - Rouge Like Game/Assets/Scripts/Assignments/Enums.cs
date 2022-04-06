using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enums : MonoBehaviour
{
    enum Color {blue,red,yellow,green,orange,purple}; // 1 can be declared outside of the public class, needs to have linar progression when defining numbers 
    enum CarMake {Honda, Cherveron, Ford, Mazda, Dodge}; //2
    enum CarModel {Alero, Cruze, Tacoma, Mustang, Viper}; //3
    enum Emotion {happy,sad,angry,disgust,fear}; //4
    enum Pets {dog, cat, fish, hamster, chicken, ferret}; //5
    enum Careers {Lawyer, Docter, Teacher, FireFighter, PoliceOfficer, GameDeveloper}; //6
    enum SchoolSubjects {Math, English, Science, History, PhysicalEducation, Art}; //7
    enum Colleges {UVU, UofU, UtahState, Dixie, SUU, BYU}; //8
    enum Majors {PolicicalScience, ComputerScience, Psycology, Engineering, GraphicArts, Education}; //9
    enum AdobeSoftware {Photoshop, Illistrator, AfterEffects, SubstancePainter, Permiere}; //10
    // Start is called before the first frame update
    void Start()
    {
       /* Color paint;
        paint = Color.blue;
        print(paint); // 1

        CarMake make;
        CarModel model;
        make = CarMake.Dodge;
        model = CarModel.Viper;
        print("Car Manufacture:" + make + "Model:" + model);
        Recall(CarMake.Mazda, CarModel.Tacoma); // 2

        Emotion Feelings;
        Careers Jobs;
        Feelings = Emotion.happy;
        Jobs = Careers.GameDeveloper;
        print("Emotion Towards Career:" + Feelings + "Career Choice:" + Jobs); //3

        Feelings = Emotion.angry;
        Jobs = Careers.Teacher;
        print("Common Emotion of Professonal:" + Feelings + "Career Choice:" + Jobs); //4

        Pets LifeLongCompanion;
        Feelings = Emotion.happy;
        LifeLongCompanion = Pets.dog;
        print ("Proven Emotion Towards Pet:" + Feelings + "Pet in Question:" + LifeLongCompanion);
        Recall(Emotion.happy, Pets.dog); //5

        Feelings = Emotion.angry;
        LifeLongCompanion = Pets.cat;
        print ("Proven Emotion Towards Pet:" + Feelings + "Pet in Question:" + LifeLongCompanion);
        Recall(Emotion.angry, Pets.cat);//6

        Colleges SchoolsInUtah;
        Majors ProgramsAtColleges;
        SchoolsInUtah = Colleges.UVU;
        ProgramsAtColleges = Majors.ComputerScience;
        print("Schools in Utah:" + SchoolsInUtah + "Best Program:" + ProgramsAtColleges); //7

        SchoolsInUtah = Colleges.Dixie;
        ProgramsAtColleges = Majors.PolicicalScience;
        print("School in Utah:" + SchoolsInUtah + "Worst Program:" + ProgramsAtColleges); //8

        SchoolSubjects Subjects;
        ProgramsAtColleges = Majors.GraphicArts;
        Subjects = SchoolSubjects.Art;
        print("Subjects Taught in High School:" + Subjects + "Majors in Colleges:"); //9

        ProgramsAtColleges = Majors.ComputerScience;
        Subjects = SchoolSubjects.Math;
        Print("Subjects Taught in High School:" + Subjects + "Majors in Colleges:"); //10

        AdobeSoftware Software;
        Software = AdobeSoftware.Photoshop;
        print("Digital Artwork");//11

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.Cherveron && model == CarModel.Alero)
        {
            print("There is a recall on your vehical due to a faulty ignition. Please take your car to your deal and manage those repairs.");
        }
        else if (make == CarMake.Ford && model == CarModel.Mustang)
        print("There is a recall on all mustangs for being too cool for their own good. Please take it to the dealer to exchange it for a practical car!");
        else
        {
            print("There is no recall notice for your vehical make and model"); 
        }


        if(Feelings == Emotion.angry && LifeLongCompanion == Pets.cat)
        {
            print("Sorry but cats are kinda freaky");
        }
        if(Feelings == Emotion.happy && LifeLongCompanion == Pets.dog)
        {
            print("The masses beloved pet");
        }
        if(Feelings == Emotion.happy && LifeLongCompanion == Pets.chicken)
        {
            print("MY superior pet :))");
        }
        else if (Feelings == Emotion.angry && LifeLongCompanion == Pets.cat && Feelings == Emotion.happy && LifeLongCompanion == Pets.dog && Feelings == Emotion.happy && LifeLongCompanion == Pets.chicken)
        {
            print("Not the superior pet.... sorry");*/
        }
    }
