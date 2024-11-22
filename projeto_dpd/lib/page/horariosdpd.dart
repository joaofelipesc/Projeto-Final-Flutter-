import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class MonitorPage extends StatelessWidget {
  final String monitorName;
  final String monitorImage;

  const MonitorPage({
    required this.monitorName,
    required this.monitorImage,
    super.key,
  });

  Future<List<String>> fetchSchedule(String name) async {
    final url = 'http://localhost:5136/api/Monitor/$name';
    final response = await http.get(Uri.parse(url));

    if (response.statusCode == 200) {
      final data = json.decode(response.body);
      // Extraindo os horários e formatando de maneira legível
      List<String> horarios = [];
      for (var item in data['horarios']) {
        var dia = item['item1']['nome'];
        var inicio = item['item2']['inicio'];
        var fim = item['item2']['fim'];
        horarios.add('$dia: $inicio - $fim');
      }
      return horarios;
    } else {
      throw Exception('Falha ao carregar horários');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Monitor: $monitorName'),
        backgroundColor: Colors.blueAccent,
      ),
      body: SingleChildScrollView(
        child: Column(
          children: [
            // Foto do Monitor
            Container(
              margin: const EdgeInsets.all(20),
              child: ClipRRect(
                borderRadius: BorderRadius.circular(15),
                child: Image.network(
                  monitorImage,
                  width: double.infinity,
                  height: 250,
                  fit: BoxFit.cover,
                ),
              ),
            ),
            // Nome do Monitor
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 20),
              child: Text(
                monitorName,
                style: TextStyle(
                  fontSize: 28,
                  fontWeight: FontWeight.bold,
                  color: Colors.blueAccent,
                ),
                textAlign: TextAlign.center,
              ),
            ),
            SizedBox(height: 20),
            // Horários do Monitor
            Padding(
              padding: const EdgeInsets.all(16),
              child: FutureBuilder<List<String>>(
                future: fetchSchedule(monitorName),
                builder: (context, snapshot) {
                  if (snapshot.connectionState == ConnectionState.waiting) {
                    return Center(child: CircularProgressIndicator());
                  } else if (snapshot.hasError) {
                    return Center(child: Text('Erro: ${snapshot.error}'));
                  } else if (!snapshot.hasData || snapshot.data!.isEmpty) {
                    return Center(child: Text('Nenhum horário disponível.'));
                  } else {
                    // Exibe os horários
                    return Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          'Horários Disponíveis:',
                          style: TextStyle(
                            fontSize: 22,
                            fontWeight: FontWeight.bold,
                            color: Colors.blueAccent,
                          ),
                        ),
                        SizedBox(height: 10),
                        ...snapshot.data!.map((horario) {
                          return Container(
                            padding: const EdgeInsets.symmetric(vertical: 5),
                            child: Text(
                              horario,
                              style: TextStyle(fontSize: 18),
                            ),
                          );
                        }).toList(),
                      ],
                    );
                  }
                },
              ),
            ),
          ],
        ),
      ),
    );
  }
}
