using System;

public class PercentNum {
    public double Value;
    
    //constructors
    public PercentNum(double _val) {
    	this.Value = _val;
    }
    public PercentNum(int _val) {
    	this.Value = Convert.ToDouble(_val);
    }
    public PercentNum(float _val) {
    	this.Value = Convert.ToDouble(_val);
    }
    public PercentNum(PercentNum _num0) {
        this.Value = _num0.Value;
    }
    public PercentNum() {
    	this.Value = 0.0;
    }
  
    //functions
	// get percent from number
	public double getPercent(int _perc){
		return ((Convert.ToDouble(_perc)/100.0)*this.Value);
	}

	// inc by percent from number
	public void incPercent(int _perc){
		this.Value = (this.Value + getPercent(_perc));
	}
	
	// dec by percent from number
	public void decPercent(int _perc){
		this.Value = (this.Value - getPercent(_perc));
	}
}