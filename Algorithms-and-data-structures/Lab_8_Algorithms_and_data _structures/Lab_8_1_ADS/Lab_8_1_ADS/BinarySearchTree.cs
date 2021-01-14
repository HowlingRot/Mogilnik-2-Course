using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8_1_ADS
{
    class BinarySearchTree
    {
        public Node Root;

	//Основные функции с деревом

		//Добавление элемента в дерево
		public void Add(int value)
		{
			if (Root == null)
			{
				Root = new Node(value);
			}
			else
				AddNotRoot(value, Root);
		}

		//Добавление элемента не являющегося корнем в дерево
		private void AddNotRoot(int value, Node root)
		{			
			if (value < root.Value)
			{
				if (root.LeftNode == null)
				{
					root.LeftNode = new Node(value);
					root.LeftNode.Parent = root;
				}
				else
				{
					AddNotRoot(value, root.LeftNode);
				}
			}
			else if (value > root.Value)
			{
				if (root.RightNode == null)
				{
					root.RightNode = new Node(value);
					root.RightNode.Parent = root;
				}
				else AddNotRoot(value, root.RightNode);
			}
		}

		//Нахождение узла дерева по его значению
		public Node Find(int value)
		{
			return Find(value, Root);
		}
		private Node Find(int value, Node root)
		{
			if (root != null)
			{
				if (value == root.Value)
				{
					return root;
				}					
				else if (value < root.Value)
				{
					return Find(value, root.LeftNode);
				}
				else
				{
					return Find(value, root.RightNode);
				}					
			}
			return null;
		}
		
		//Удаление элемента
		public void Delete(int value,bool change)
		{
			if (Root != null)
			{
				Node executed;
				executed = Find(value, Root);

				if (executed != null)
				{
					

					//Если у узла нет наследников
					if (executed.LeftNode == null && executed.RightNode == null)
					{
						if (executed != Root)
						{
							if (executed.Parent.LeftNode == executed)
							{
								executed.Parent.LeftNode = null;
							}
							else
							{
								executed.Parent.RightNode = null;
							}								
						}
								executed = null;
					}								
					else if (change)
					{
						if (executed.RightNode == null) 
						{
							if (executed.Parent != null)
							{
								if (executed.Parent.LeftNode == executed)
									executed.Parent.LeftNode = executed.LeftNode;
								else
									executed.Parent.RightNode = executed.LeftNode;
							}

							executed.LeftNode.Parent = executed.Parent;

							executed = null;

						}
						else
							RightDelete(executed);
					}
					else
					{
						if (executed.LeftNode == null) 
						{
							if (executed.Parent != null)
							{
								if (executed.Parent.LeftNode == executed)
									executed.Parent.LeftNode = executed.RightNode;

								else executed.Parent.RightNode = executed.RightNode;
							}
							executed.RightNode.Parent = executed.Parent;

							executed = null;
						}
						else LeftDelete(executed);
					}
				}
				else Console.WriteLine("Нельзя удалить несуществующий элемент");
			}			
		}

		//Правое удаление элемента
		private void RightDelete(Node Root)
		{
			Node executed = Root.RightNode;

			while (executed.LeftNode != null)
				executed = executed.LeftNode;

			if (executed.Parent != Root)
			{
				if (executed.RightNode != null) 
				{
					executed.Parent.LeftNode = executed.RightNode;

					executed.RightNode.Parent = executed.Parent;
				}

				executed.RightNode = Root.RightNode;
				Root.RightNode.Parent = executed;
				executed.Parent.LeftNode = null;
			}

			executed.LeftNode = Root.LeftNode;
			if (Root.LeftNode != null)
				Root.LeftNode.Parent = executed;

			if (Root.Parent != null) 
			{
				if (Root.Parent.LeftNode == Root)
					Root.Parent.LeftNode = executed;
				else Root.Parent.RightNode = executed;
			}

			executed.Parent = Root.Parent;

			if (Root == this.Root) 
			{
				this.Root = null;
				this.Root = executed;
			}
			else
			{
				Root = null;
				Root = executed;
			}
		}

		//Левое удаление элемента
		private void LeftDelete(Node Root)
		{
			Node executed = Root.LeftNode;
			while (executed.RightNode != null)
				executed = executed.RightNode;

			if (executed.Parent != Root)
			{
				if (executed.LeftNode != null)
				{
					executed.Parent.RightNode = executed.RightNode;

					executed.LeftNode.Parent = executed.Parent;
				}

				executed.LeftNode = Root.LeftNode;
				Root.LeftNode.Parent = executed;
				executed.Parent.RightNode = null;
			}

			executed.RightNode = Root.RightNode;
			if (Root.RightNode != null)
				Root.RightNode.Parent = executed;

			if (Root.Parent != null) 
			{
				if (Root.Parent.LeftNode == Root)
					Root.Parent.LeftNode = executed;
				else Root.Parent.RightNode = executed;
			}

			executed.Parent = Root.Parent;

			if (Root == this.Root)
			{
				this.Root = null;
				this.Root = executed;
			}
			else
			{
				Root = null;
				Root = executed;
			}
		}

		//Нахождение глубины узла
		public int GetDepth(int value)
		{
			if (Root != null)
			{
				Node element = Find(value, Root);
				if (element == null)
				{
					Console.WriteLine("Нельзя найти глубину несуществующего элемента");
					return -1;
				}
				else
				{
					int depth = 0; 
					if (element != Root)
					{
						depth = 1 + SubDepth(element.Parent);
					}											
					return depth;
				}
			}
			return -1;
		}

		//Рекурсивная функция для функции GetDepth
		private int SubDepth(Node root)
		{
			int depth = 0;
			if (root.Parent != null)
				depth = 1 + SubDepth(root.Parent);
			return depth;
		}

		//Функция для нахождения высоты узла
		public int GetHeight(int value)
		{
			if (Root != null)
			{
				Node element = Find(value, Root);
				if (element == null)
				{
					Console.WriteLine("Нельзя найти высоту несуществующего элемента");
					return -1;
				}
				else
				{
					int height = 0;
					height = Math.Max(SubHeight(element.LeftNode), SubHeight(element.RightNode));
					return height;
				}
			}
			return -1;
		}

		//Рекурсивная функция для функции GetHeight
		private int SubHeight(Node root)
		{
			int height = 0;
			if (root != null)
			{
				height = 1 + Math.Max(SubHeight(root.LeftNode), SubHeight(root.RightNode));
			}
			return height;
		}

		//Функция для нахождения уровня узла
		public int GetLevel(int value)
		{
			if (Root != null)
			{
				Node element = Find(value, Root);
				if (element == null)
				{
					Console.WriteLine("Нельзя найти уровень несуществующего элемента");
					return -1;
				}
				else
				{
					int level = 0;
					if (element != Root)
						level = SubHeight(Root) - SubDepth(element) - 1;
					return level;
				}			
			}
			return -1;
		}

		//Прямой обход дерева
		public void TraversePreOrder(Node parent)
		{
			if (parent != null)
			{
				Console.Write(parent.Value + " ");
				TraversePreOrder(parent.LeftNode);
				TraversePreOrder(parent.RightNode);
			}
		}

		//Симметричный обход дерева
		public void TraverseInOrder(Node parent)
		{
			if (parent != null)
			{
				TraverseInOrder(parent.LeftNode);
				Console.Write(parent.Value + " ");
				TraverseInOrder(parent.RightNode);
			}
		}
		
		//Обратный обход дерева
		public void TraversePostOrder(Node parent)
		{
			if (parent != null)
			{
				TraversePostOrder(parent.LeftNode);
				TraversePostOrder(parent.RightNode);
				Console.Write(parent.Value + " ");
			}
		}

		//Функция для вывода дерева
		public void PrintTree()
		{
			if (Root != null)
				Root.PrintNode("", NodePosition.center, true, false);
			else
				Console.WriteLine("Дерева не существует");
		}

	}
}

