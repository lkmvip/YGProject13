function DestroyMonster(UserWorldId, MonsterId) 
       if MonsterId==15551 then 
             Monster15551(UserWorldId) 
       end 
       if MonsterId==15551 then 
             Monster15551(UserWorldId) 
       end 
end 


-----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------

-----[15551]---[18]---------------------------------------------------------------
function Monster15551(UserWorldId) 
       local  bool900000655 = GetQuestItme(UserWorldId, 900000655, 5) 
       if bool900000655 then 
             return 
       else 
             local Player = GetPlayer(UserWorldId) 
             local QuestLevel=GetQuestLevel(UserWorldId,18) 
             if QuestLevel == 2 then 
                   local ran=math.random(1,100) 
                   if ran<=70 then 
                         AddQuestItme(UserWorldId,900000655,1) 
                   end 
             end 
       end 
end 

-----[15551]---[18]---------------------------------------------------------------
function Monster15551(UserWorldId) 
       local  bool900000025 = GetQuestItme(UserWorldId, 900000025, 5) 
       if bool900000025 then 
             return 
       else 
             local Player = GetPlayer(UserWorldId) 
             local QuestLevel=GetQuestLevel(UserWorldId,18) 
             if QuestLevel == 2 then 
                   local ran=math.random(1,100) 
                   if ran<=70 then 
                         AddQuestItme(UserWorldId,900000025,1) 
                   end 
             end 
       end 
end 

