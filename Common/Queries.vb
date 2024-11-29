Module Queries
    Public ReadOnly CONNECTION_STRING As String = "server=localhost;user=root;database=forecastdb;port=3306;password=stephen;"
    'Public ReadOnly CONNECTION_STRING As String = "server=localhost;user=root;database=forecastdb;port=3306;password=Develop@2021;"
    Public ReadOnly LOGIN_QUERY As String = "Select * FROM users WHERE username=@username"
    Public ReadOnly CREATE_ACCOUNT_QUERY As String = "INSERT INTO users (firstName,middleName,lastName,username,password,userType,created_at) VALUES (@firstName,@middleName,@lastName,@username,@password,@userType,NOW())"
    Public ReadOnly CREATE_HISTORY_QUERY As String = "INSERT INTO history (userID,description,input,output,date) VALUES (@id,@desc,@in,@out,NOW())"
    Public ReadOnly SELECT_HISTORY_USER_QUERY As String = "SELECT * FROM history WHERE userID=@userID"
    Public ReadOnly SELECT_HISTORY_ADMIN_QUERY As String = "SELECT * FROM history"
    Public ReadOnly SELECT_TOP_DATE_QUERY As String = "SELECT MAX(dateLogs) as date FROM `weather_data`"
    Public ReadOnly SELECT_WEATHER_DATA_QUERY As String = "SELECT * FROM `weather_data`"
End Module
