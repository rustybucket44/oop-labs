using System;

public class TCircle {
    public int Radius;
    
    //constructors
    public TCircle(int _rad) {
    	this.Radius = _rad;
    }
    public TCircle(TCircle _circle0) {
        this.Radius = _circle0.Radius;
    }
    public TCircle() {
    	this.Radius = 0;
    }
    
    //functions
    public virtual int getArea(){
        return (int)Math.Round(Math.PI*this.Radius*this.Radius);
    }
    public double getCircleLength(){
        return (int)Math.Round(2*Math.PI*this.Radius);
    }
    public virtual bool isBiggerThan(TCircle _circle0){
        if (this.Radius > _circle0.Radius) {
            return true;
        }else{
            return false;
        }
    }
    public void incRad(int inc){
        int res = this.Radius + inc;
        if (res < 0) {
            this.Radius = 0;
        }else{
            this.Radius = res;
        }
    }
    public void mulRad(double mul){
        this.Radius = (int)Math.Round(this.Radius*mul);
    }
}