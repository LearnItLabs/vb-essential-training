imports system

module program
 sub main(args as string())
   console.writeline("what is your favorite color?")
   dim favcolor as string = console.readline()
   console.writeline ("that's a nice color. what do you like about " & favcolor & "?")
   console.readline

  end sub
end module
