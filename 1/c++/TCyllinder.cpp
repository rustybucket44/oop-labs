#include "TCircle.cpp"
class TCyllinder : public TCircle {
    public:
		int Height;
	
    	//constructor
    	TCyllinder(void){
    		Radius = 0;
    		Height = 0;
    	}
    	TCyllinder(int _rad, int _height){
    		Radius = _rad;
    		Height = _height;
    	}    
    	TCyllinder(const TCyllinder & _cyll0){
    		Radius = _cyll0.Radius;
    		Height = _cyll0.Height;
    	}    
    	~TCyllinder(){}
    
		//functions
		void incHeight(int inc){
			int res = Height + inc;
			if (res < 0) {
				Height = 0;
			}else{
				Height = res;
			}
		}
		
		void mulHeight(double mul){
			Height = int(round(Height*mul));
		}
		
		int getVolume(){
			return int(round(Height*3.14*Radius*Radius));
		}
		
		int getArea(){
			return int(round(2*3.14*Radius*(Radius+Height)));
		}
};