var manager = new TaskManager();
bool running = true;

while (running)
{
    Console.WriteLine("\n=== Gerenciador de Tarefas ===");
    Console.WriteLine("1. Adicionar tarefa");
    Console.WriteLine("2. Listar tarefas");
    Console.WriteLine("3. Concluir tarefa");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Write("Digite o título da tarefa: ");
            var title = Console.ReadLine();
            try
            {
                var task = manager.AddTask(title ?? string.Empty);
                Console.WriteLine($"Tarefa '{task.Title}' adicionada com sucesso! (ID: {task.Id})");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            break;

        case "2":
            Console.WriteLine("\n--- Lista de Tarefas ---");
            if (manager.Tasks.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                foreach (var item in manager.Tasks)
                {
                    var status = item.IsCompleted ? "[X]" : "[ ]";
                    Console.WriteLine($"{status} ID: {item.Id} | Título: {item.Title}");
                }
            }
            break;

        case "3":
            Console.Write("Digite o ID da tarefa para concluir: ");
            var idInput = Console.ReadLine();
            if (Guid.TryParse(idInput, out var guid))
            {
                bool success = manager.CompleteTask(guid);
                if (success)
                {
                    Console.WriteLine("Tarefa concluída com sucesso!");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
            break;

        case "4":
            running = false;
            Console.WriteLine("A encerrar a aplicação...");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }
}