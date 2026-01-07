using System;

class User
{
    public int id;
    public string name;
    public int age;
    public Friend friends;
    public User next;
}

class Friend
{
    public int friendId;
    public Friend next;
}

class SocialMedia
{
    User head;
    
    public void AddUser(int i, string n, int a)
    {
        User u = new User();
        u.id = i; u.name = n; u.age = a;
        u.next = head; head = u;
    }
    
    public void AddFriend(int uid, int fid)
    {
        User u = FindUser(uid);
        if (u != null)
        {
            Friend f = new Friend();
            f.friendId = fid;
            f.next = u.friends;
            u.friends = f;
        }
    }
    
    public void RemoveFriend(int uid, int fid)
    {
        User u = FindUser(uid);
        if (u == null || u.friends == null) return;
        if (u.friends.friendId == fid) { u.friends = u.friends.next; return; }
        Friend temp = u.friends;
        while (temp.next != null && temp.next.friendId != fid) temp = temp.next;
        if (temp.next != null) temp.next = temp.next.next;
    }
    
    public void FindMutualFriends(int uid1, int uid2)
    {
        User u1 = FindUser(uid1);
        User u2 = FindUser(uid2);
        if (u1 == null || u2 == null) return;
        
        Friend f1 = u1.friends;
        while (f1 != null)
        {
            Friend f2 = u2.friends;
            while (f2 != null)
            {
                if (f1.friendId == f2.friendId)
                    Console.WriteLine($"Mutual friend: {f1.friendId}");
                f2 = f2.next;
            }
            f1 = f1.next;
        }
    }
    
    public void DisplayFriends(int uid)
    {
        User u = FindUser(uid);
        if (u == null) return;
        Friend f = u.friends;
        while (f != null)
        {
            Console.WriteLine($"Friend: {f.friendId}");
            f = f.next;
        }
    }
    
    public User SearchByName(string n)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.name == n) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public User FindUser(int i)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.id == i) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public int CountFriends(int uid)
    {
        User u = FindUser(uid);
        if (u == null) return 0;
        int count = 0;
        Friend f = u.friends;
        while (f != null) { count++; f = f.next; }
        return count;
    }
    
    public void DisplayUsers()
    {
        User temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.id} {temp.name} {temp.age} Friends: {CountFriends(temp.id)}");
            temp = temp.next;
        }
    }
}