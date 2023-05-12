interface IPercentNum {
    double Value { get; set; }
    
    double getPercent(int _perc);
    void incPercent(int _perc);
    void decPercent(int _perc);
}