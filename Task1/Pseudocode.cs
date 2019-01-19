//setup
single milesDriven = 0;
single gallonsUsed = 0;
double rate = 0.0;


//input
do {
PUT "How many miles were driven?"
GET milesDriven;

} while(milesDriven >= 0 && milesDriven = single));
    
do {
PUT "How many gallons did your car need to refill the tank after" + milesDriven + " were driven?"
GET gallonsUsed;

} while(gallonsUsed >= 0 && gallonsUsed = single));

//process
rate = milesDriven / gallonsUsed;

//Output
PUT "your car's average miles per gallon is " + rate + " mpg"

