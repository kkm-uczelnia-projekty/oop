#!/usr/bin/env ts-node

import { createServer as createTcpServer } from "net";

const server = createTcpServer((socket) => {
  socket.on("connect", () => {
    console.log("connect");
  });

  socket.on("ready", () => {
    console.log("ready");
  });

  socket.on("data", (data) => {
    console.log(data.toString("utf-8"));
  });
});
server.listen(1234);
