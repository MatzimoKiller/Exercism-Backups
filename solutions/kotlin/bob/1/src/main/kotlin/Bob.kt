object Bob {
    fun hey(input: String): String {
        val isYelling = input.trim().toCharArray().all{ it.isUpperCharOrOther() } && input.trim().toCharArray().any{ it.isLetter() }
        val isQuestion = input.trim().length > 0 && input.trim().last().compareTo('?') == 0
        val isSilence = input.isBlank()
        when {
            isYelling && isQuestion -> return "Calm down, I know what I'm doing!";
            isQuestion -> return "Sure.";
            isYelling -> return "Whoa, chill out!";
            isSilence -> return "Fine. Be that way!";
            else -> return "Whatever.";
        }
    }
}

fun Char.isUpperCharOrOther() = !isLetter() || isUpperCase()
