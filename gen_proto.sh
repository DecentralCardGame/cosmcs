cd ./cosmos-sdk/proto

buf generate --template ../../buf.gen.types.yaml --include-imports
buf generate --template ../../buf.gen.client.yaml $(find | grep /tx.proto | awk '{print "--path="$1}' | xargs)

cd ../../