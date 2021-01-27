#public static void DoNothingTo1<T1, T2>(T1 t1, T2 t2) { }



# Parameters:
FILE_NAME = "NothingDoer.cs"
NAMESPACE = "JesseRussell.LinqExtension"
METHOD_NAME_1 = "DoNothing"
METHOD_NAME_2 = "GetNothing"
CLASS_NAME = "NothingDoer"
TYPE_PARAMETER_COUNT = 64
#

# Constants:
INDENT = "    "
#


def methodFullName(typeCount, methodName, returnName = None):
    result =  methodName
    if returnName == None:
        return result
    else:
        return result + "<" + returnName + ">"

    # else:
    #     result += "<"
    #
    #     if returnName != None:
    #         result += returnName + ", "
    #
    #     firstLoop = True
    #
    #     for i in range(1, typeCount + 1):
    #         if not firstLoop:
    #             result += ", "
    #         result += "T" + str(i)
    #
    #         firstLoop = False
    #
    #     result += ">"
    #     return result;

def methodParamList(typeCount):
    result = "("
    firstLoop = True
    for i in range(1, typeCount + 1):
        if not firstLoop:
            result += ", "
        result += "object" + " i" + str(i)
        # result += "T" + str(i) + " i" + str(i)
        firstLoop = False
    result += ")"
    return result

def fullMethodId(typeCount, methodName, returnName = None):
    result = "public static "
    if returnName == None:
        result += "void"
    else:
        result += returnName
    result += " " + methodFullName(typeCount, methodName, returnName) + methodParamList(typeCount)
    return result



# Open output file.
output = open(FILE_NAME, "w")

# o ================= o
# | Begin generation: |
# o ================= o

# namespace
output.write("namespace " + NAMESPACE + "\n")
output.write("{\n")

    # class
output.write(INDENT + "public static class " + CLASS_NAME + "\n")
output.write(INDENT + "{\n")

    # methods
for i in range(1, TYPE_PARAMETER_COUNT + 1):
    output.write(INDENT * 2 + fullMethodId(i, METHOD_NAME_1) + "{ }\n")
    # output.write(INDENT * 2 + "public static void " + methodFullName(i, METHOD_NAME_1) + "() { }\n")

    # methods_2
for i in range(1, TYPE_PARAMETER_COUNT + 1):
    output.write(INDENT * 2 + fullMethodId(i, METHOD_NAME_2, "R") + " { return default; }\n")

    # special methods:
output.write(INDENT * 2 + "public static void DoNothing(params object[] i) { }\n")
output.write(INDENT * 2 + "public static R GetNothing<R>(params object[] i) { return default; }\n")

    # end class
output.write(INDENT + "}\n")

# end namespace
output.write("}\n")