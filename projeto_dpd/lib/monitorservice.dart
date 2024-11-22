import 'dart:convert';
import 'package:http/http.dart' as http;

class MonitorService {
  // Função que busca os dados da API e retorna uma lista de monitores
  Future<List<Map<String, dynamic>>> fetchMonitors() async {
    final url = 'http://localhost:5136/api/Monitor'; // URL da sua API
    try {

      final response = await http.get(Uri.parse(url));

      if (response.statusCode == 200) {
        List<dynamic> data = json.decode(response.body);

        return data.map((item) {
          return {
            'name': item['nome'],  // Ajuste o nome da chave conforme sua API
            'image': item['urlFoto'], // Ajuste o nome da chave conforme sua API
          };
        }).toList();
      } else {
        throw Exception('Failed to load data');
      }
    } catch (e) {
      // Tratamento de erro
      print('Error: $e');
      return [];
    }
  }
}
