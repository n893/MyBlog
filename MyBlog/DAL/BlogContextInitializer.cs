using System;
using System.Collections.Generic;
using System.Data.Entity;
using MyBlog.DataContract;

namespace MyBlog.DAL
{
	public class BlogContextInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
	{
		protected override void Seed(BlogContext context)
		{
			var posts = new List<Post>
			            {
				            new Post() {Date = DateTime.Now, Name = "First", Text = @"На розпутті кобзар сидить
Та на кобзі грає,
Кругом хлопці та дівчата,
Як мак процвітає.
Грає кобзар, виспівує,
Вимовля словами,
Як москалі, орда, ляхи
Бились з козаками,
Як збиралась громадонька
В неділеньку вранці,
Як ховали козаченька
В зеленім байраці.
Грає кобзар, виспівує,
Аж лихо сміється..."},
				            new Post() {Date = DateTime.Now, Name = "Second", Text = @"I wanna be your vacuum cleaner
Breathing in your dust
I wanna be your Ford Cortina
I won't ever rust
If you like your coffee hot
Let me be your coffee pot
You call the shots babe
I just wanna be yours"}
			            };
			posts.ForEach(p => context.Posts.Add(p));

			base.Seed(context);
		}
	}
}