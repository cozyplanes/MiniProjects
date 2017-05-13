
CHARS = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890'

def GeneratePassword(length)
    password = ''
    length.times do
        password += CHARS[rand CHARS.length - 1]
    end
    
    password 
end

puts GeneratePassword 10