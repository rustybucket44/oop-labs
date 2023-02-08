#include <math.h>
class TCircle {
    public:
		int Radius;
	
	//constructors	
	TCircle(void){
		Radius = 0;
	}
	TCircle(int _rad){
		Radius = _rad;
	}
	TCircle(const TCircle & _circle0){
		Radius = _circle0.Radius;
	}
	~TCircle(){}
	
	//functions
    int getArea(){
        return int(round(3.14*Radius*Radius));
    }
    double getCircleLength(){
        return int(round(2*3.14*Radius));
    }
    bool isBiggerThan(TCircle _circle0){
        if (Radius > _circle0.Radius) {
            return true;
        }else{
            return false;
        }
    }
    void incRad(int inc){
        int res = Radius + inc;
        if (res < 0) {
            Radius = 0;
        }else{
            Radius = res;
        }
    }
    void mulRad(double mul){
        Radius = int(round(Radius*mul));
    }
};