cd ./cosmos-sdk/proto

buf generate --template ../../buf.gen.yaml --include-imports

rm $(find ../../Buf | grep "TxGrpc.pb.cs")
