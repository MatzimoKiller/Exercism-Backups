object CollatzCalculator {
    fun computeStepCount(start: Int): Int {
        if(start < 1){
            throw IllegalArgumentException("Invalid input.")
        }
        
        var steps = 0
        var actual = start

        while(actual != 1){
            steps++
            actual= if (actual % 2 == 0) actual / 2 else actual * 3 + 1
        }
        return steps
    }
}
