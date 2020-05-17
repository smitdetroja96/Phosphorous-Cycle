
//SMIT DETROJA
//201601113

#include <iostream>
#include <bits/stdc++.h>
#include <time.h>


using namespace std;

double years[51];


void soilMoisture(){
    // for soil moisture of year say 2038 use the index as year%100
    // for example for year 2038 index = 2038%100 = 38
    srand(time(NULL));
    years[0] = 0;
    years[18] = 0.655;
    int max = years[18] * 1000.0;
    //cout<<max<<endl;
    for(int i=17 ; i>0 ; i--)
        {
        int temp = rand()%max;
        double tmp;
        if((max-temp) <= 9 && temp != 0){
            int t = max - temp;
            temp = max + t;
            tmp = temp/1000.0;
            years[i] = tmp;
            max = temp;
        }
        else{
            i++;
        }
    }
    max = years[18] * 1000;
    for(int i=19 ; i<=50 ; i++){
        int temp = rand()%max;
        double tmp = temp * 0.001;
        if((max-temp) <= 10 && temp != 0){
            tmp = temp/1000.0;
            years[i] = tmp;
            max = temp;
        }
        else{
            i--;
        }
    }
}



int main()
{
    //Current moisture s = year averaged soil moisture

    //Current s = 0.655
    // input year

    //Bound phosphorous  - conversion
    //uplift irrigation - ground water
    soilMoisture();

    while(1){
    int year;
    cout<<"Enter the year in which you want to find"<<endl;
    cin>>year; //--------------------------------------------------------------------------/Year 2001 - 2050

    year = year - 2000;

    //Land - 19.7 - 30.4 x pow(10,12) g/year
    double River;

    double Land; // River= //6.9 - 12.2 x pow(10,12) g/year

    srand(time(NULL));


    int land = rand() % 107 + 200;
    Land = land / 11.0;
    cout<<Land<<" x 10^12 gram phosphorous comes into soil"<<endl;

    //F_wd is the amount of phosphorous came into the soil every year by weathering.
    int river = rand() % 540 + 790;
    River = river / 100.0;


    while(Land - River <=10)
    {
        int river = rand() % 540 + 790;
        River = river / 100.0;

    }

    cout<<River<<" x 10^12 gram phosphorous comes into river"<<endl;

    //Phosphorous uptake by vegetation
    double veggie;

    double Ku; //Active uptake of vegetation which depends on the type of vegetation we grow 7-14
//  User Gives the input of ku.
    int ku = rand() % 8 + 7;
    Ku = ku * 1.0; //-------------------------------------------------------------------------- // Active uptake of vegetation 7-14

   // cout<<Ku<<" is the active uptake of vegetation which depends on the type of vegetation we grow"<<endl;

    int n = (rand()%3) + 2;

    double N = n*1.0; //-----------------------------------------------------------------------------//Micro-organism factor 3/4/5

    int zr = rand() % 290 + 1640;

    double Zr = zr / 10.0;

    veggie = (((Ku * N * years[year] * Land * 1.0)/ 0.4) /(Zr*1.0))/2.0;
    cout<<veggie<<" x 10^12 gram of phosphorous is available in organic form"<<endl;

    cout<<Land - veggie - River<<" x 10^12 gram of phosphorous available in mineral form"<<endl;


    double sediment = Land /10.0;
    cout<<sediment<<" x 10^11 gram of phosphorous is deposited on the sea floor"<<endl;

    cout<<"-------------------------------------------------------------------------------------------------------"<<endl;




    }

/*

    ll year;
    cin>>year;

    ll mod_year =

  */
}
