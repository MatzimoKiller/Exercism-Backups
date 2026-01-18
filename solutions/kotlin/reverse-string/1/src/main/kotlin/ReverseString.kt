fun reverse(input: String): String {
    var output = ""
    for (char in input){
        output = char + output
    }
    return output
}
