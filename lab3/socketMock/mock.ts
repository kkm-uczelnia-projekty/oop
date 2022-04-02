#!/usr/bin/env ts-node

import { createServer as createTcpServer } from "net";
createTcpServer((socket) => {
  socket.on("data", (data) => {
    console.log(data.toString("utf-8"));
  });
}).listen(1234);
