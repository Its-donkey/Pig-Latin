Imports System.Text

Public Class frmPigLatin
    Private Sub btnClearInputText_Click(sender As Object, e As EventArgs) Handles btnClearInputText.Click
        txtWordInput.Clear()
        txtConversionOutput.Clear()
    End Sub

    Private Sub btnConvertText_Click(sender As Object, e As EventArgs) Handles btnConvertText.Click


        Dim input As String = txtWordInput.Text
        'Check that there is an input
        If String.IsNullOrEmpty(input) Then
            MsgBox("No valid text has been entered to translate")
            Exit Sub
        End If

        'Split text into array
        Dim words() As String = input.Split(CType(" ", Char()))
            Dim firstCharacter As String
            Dim outputText As New StringBuilder

            For i As Integer = 0 To words.GetUpperBound(0)

            firstCharacter = words(i).First

            If firstCharacter = """" And words(i).Last = """" Then
                    GoTo AppendText
                End If

                If words(i).Length > 2 Then

                ''Determine the casing of each letter for output
                Dim wordCharacters() As Char = words(i).ToCharArray()
                'Dim wordCharacterCasing(wordCharacters.GetUpperBound(0)) As Boolean

                'check if a symbol or number is within the word. If it is then go to output
                For Each s In "@#$%^&*1234567890".ToCharArray
                        For Each wc In words(i).ToCharArray()
                            If s = wc Then
                                GoTo AppendText
                            End If
                        Next
                    Next

                    'Check if punctuation is on the end of the word.
                    Dim punctuationMark As String = words(i).Last
                    Dim attachedPunctuation As String = Nothing

                    For Each p In "':,—!-().?"";".ToCharArray()
                        If punctuationMark = p Then
                            words(i) = words(i).Remove(words(i).Length - 1) 'remove punctuation so it doesn't appear mixed in the word if it is on the end i.e. Hllo World,
                            attachedPunctuation = p 'set the value of the punctuation so it can be reattached later
                        End If
                    Next

                    Select Case firstCharacter

                        Case "a", "e", "i", "o", "u",
                             "A", "E", "I", "O", "U"
                        'If the word starts with a vowel, add 'way' to the end
                        words(i) = words(i) & "way" & attachedPunctuation

                    Case "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z",
                             "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"

                            Dim vowelFirstIndex As Integer = 999

                            For Each c In "aeiouy".ToCharArray()
                                If words(i).IndexOf(c) <> -1 And words(i).IndexOf(c) < vowelFirstIndex Then
                                    vowelFirstIndex = words(i).IndexOf(c)
                                End If
                            Next

                            Dim charactersToMove As String = words(i).Substring(0, vowelFirstIndex)



                            words(i) = words(i).Remove(0, vowelFirstIndex) & charactersToMove & "ay" & If(attachedPunctuation IsNot Nothing, attachedPunctuation, "")
                    End Select

                End If
AppendText:
                outputText.Append(words(i) & " ")
            Next

            txtConversionOutput.Text = outputText.ToString

    End Sub

    Private Sub txtWordInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWordInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    'Provide some samples to show trnaslation.
    Private Sub cmbSampleSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSampleSelection.SelectedIndexChanged

        Select Case cmbSampleSelection.SelectedIndex
            Case 0
                txtWordInput.Text = "Doc Bruce Banner, pelted by gamma rays, turned into the Hulk - ain't he unglamorous! Wreckin' the town with the power of a bull, Ain't no monster cause who is that lovable? It's ever-lovin' Hulk!...Hulk! Hulk!

Marshall, Will, and Holly on a routine expedition, met the greatest earthquake ever known. High on the rapids, it struck their tiny raft! And plunged them down a thousand feet below... to the Land of the Lost! Lost! Lost! Lost! Lost!

This is it, this is it. This is life, the one you get, so go and have a ball. This is it, this is it. Straight ahead, and rest assured you can't be sure at all. So while you're here enjoy the view, keep on doing what you do, so hold on tight we'll muddle through one day at a time, one day at a time. So up on your feet, up on your feet - somewhere there's music playing. Don't you worry none, we'll just take it like it comes, one day at a time, one day at a time.
"
            Case 1
                txtWordInput.Text = "Yogi Bear is smarter than the average bear, Yogi Bear is always in the ranger's hair. At a picnic table you will find him there, stuffing down more goodies than the average bear. He will sleep till noon but before it's dark, he'll have every picnic basket that's in Jellystone Park. Yogi has it better than a millionaire. That's because he's smarter than the average bear!

My name is Rhoda Morgenstern. I was born in the Bronx, New York in December of 1941. I've always felt responsible for World War II. The first thing I remember liking that liked me back was food. I had a bad puberty; it lasted seventeen years. I'm a high school graduate. I went to art school. My entrance exam was on a book of matches. I decided to move out of the house when I was twenty-four. My mother still refers to this as the time I ran away from home. Eventually, I ran to Minneapolis, where it's cold and I figured I'd keep better. Now I'm back in Manhattan. New York, this is your last chance!

There were six people who loved to watch television, but they didn't like what they saw. Armed with determination and a strong will to change the course of television, they wrote their own shows, but that wasn't enough, they had to sell them. They went straight to the networks, but the networks were not ready for them. But did that stop them? No. They built their own network and they liked what they saw.
"

            Case 2
                txtWordInput.Text = "In an age when nature and magic rule the world, there is an extraordinary legend: the story of a warrior who communicates with animals, who fights sorcery and the unnatural. His name is Dar, last of his tribe. He is also called Beastmaster.

Tell me why, I love you like I do. Tell me who, could stop my heart as much as you. Let's take each other's hand, as we jump into the final frontier. Mad about you baby, yeah, I'm mad about you. Whoo hoo hoo.

Overture, curtains, lights. This is it, the night of nights. No more rehearsing and nursing a part, we know every part by heart! Overture, curtains, lights. This is it, you'll hit the heights. And oh, what heights we'll hit. On with the show this is it. Tonight what heights we'll hit, on with the show this is it!

"

            Case 3
                txtWordInput.Text = "Now, the world don't move to the beat of just one drum, what might be right for you, may not be right for some. A man is born, he's a man of means. Then along come two, they got nothing but their jeans. But they got, Diff'rent Strokes, it takes Diff'rent Strokes. It takes Diff'rent Strokes to move the world.

Boy the way Glen Miller played, songs that made the hit parade. Guys like us we had it made, those were the days. And you knew who you were then, girls were girls and men were men. Mister, we could use a man like Herbert Hoover again. Didn't need no welfare state, everybody pulled his weight. Gee our old LaSalle ran great. Those were the days.

They arrived in fifty mother ships, offering their friendship and advance technology to Earth. Skeptical of the visitors, Mike Donovan and Juliet Parrish infiltrated their ranks and soon discovered some startling secrets. The resistance is all that stands between us... and the visitors.

"

            Case 4
                txtWordInput.Text = "Dr. David Banner: physician; scientist. Searching for a way to tap into the hidden strengths that all humans have... then an accidental overdose of gamma radiation alters his body chemistry. And now when David Banner grows angry or outraged, a startling metamorphosis occurs. The creature is driven by rage and pursued by an investigative reporter. The creature is wanted for a murder he didn't commit. David Banner is believed to be dead, and he must let the world think that he is dead, until he can find a way to control the raging spirit that dwells within him.

There are those who believe that life here began out there... far across the universe, with tribes of humans who may have been the forefathers of the Egyptians or the Toltecs or the Mayans. Some believe that there may yet be brothers of man who even now fight to survive somewhere beyond the heavens. Fleeing from the Cylon Tyranny, the last Battlestar - Galactica - leads a rag-tag fugitive fleet on a lonely quest. A shining planet, known as Earth.

Baby if you've ever wondered, wondered what ever became of me. I'm living on the air in Cincinnati, Cincinnati WKRP. Got time and tired of packing and unpacking. Town to town, up and down the dial. Maybe you and me were never meant to be, But baby think of me once in a while. I'm in WKRP in Cincinnati.

"
        End Select



    End Sub

End Class
