object Bob {
    fun hey(input: String): String {
        val clearInput = input.trim()
        val isYelling = clearInput.toCharArray().all{ it.isUpperCharOrOther() } && clearInput.toCharArray().any{ it.isLetter() }
        val isQuestion = clearInput.length > 0 && clearInput.endsWith("?")
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
