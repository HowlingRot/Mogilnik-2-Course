using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8_2_ADS
{
    class BinarySearchTree
    {
		public Node Root;

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
		public void Delete(int value, bool change)
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
		public void RightDelete(Node Root)
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
