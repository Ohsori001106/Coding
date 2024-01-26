using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cat cat1 = new Cat();
        cat1.Name = "나비";
        cat1.Age = 5;
        cat1.Color = "크림 브라운";
        cat1.Species = "벵골 고양이";
        cat1.Weigh = 6f;
        cat1.LikeWater = true;

        Cat cat2 = new Cat("고앵이",3,"흰색","페르시안",5.4f,false);          

        Dog dog1 = new Dog ("철수",2,"회색","시베리아허스키",20.5f,true);

        Dog dog2 = new Dog("흰둥이",5,"흰색","말라뮤트",25f,false);

        cat1.Speak();
        cat2.Speak();
        dog1.Speak();
        dog2.Speak();

        cat1.Run();
        cat2.Run();
        cat1.Sleep();
        cat2.Sleep();
        cat1.Howl();
        cat2.Howl();
        cat1.Grooming(cat2);
        cat2.Grooming(dog2);

        dog1.Run(); 
        dog2.Run();
        dog1.Sleep(); 
        dog2.Sleep();
        dog1.Howl();
        dog2.Howl();
        dog1.Take(dog2);
        dog2.Take(cat1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
