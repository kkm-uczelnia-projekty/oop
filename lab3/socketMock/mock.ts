#!/usr/bin/env ts-node

import WebSocket from "ws";

const main = () => {
  const port = +`${process.env.WS_PORT || 1234}`;
  const wss = new WebSocket.Server({
    port,
  });

  console.log(`ws started on port ${port}`);
  wss.on("connection", (ws) => {
    console.log("connection");

    ws.on("message", (data) => {
      console.log(data);
    });
  });
};

main();
