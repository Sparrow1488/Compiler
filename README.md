# Compiler

**Example to compile: **

SHORTCUT Compilation-name-${counter}.auto
DESCRIPTION "Dolore aliquip nostrud sunt culpa irure ex."
TAGS tag1,tag2,tag3

ON-CREATE PIPELINE:
    FROM ./dir/files
    TAKE all
    WITH RULES:
        NEW ScaleRule:
            () => true; START ScaleProcess;
        NEW EncodingRule:
            ${video}.videoStream.encoding not libx264;
            START EncodingProcess(VideoEncoding.Libx264);
        NEW LoopRule:
            ${video}.videoStream.duration lower 15;
            ${video}.references.add(new reference(
                ${video}.path, referenceType.render
            ));
    OUTPUT ${config}.paths.output

ON-CREATED:
    PUBLISH ${publishers}.vk
        TO GROUP group_name

        WITH PERMISSIONS:
            LOGIN vk_login
            PASSWORD vk_password
 ### or
        WITH PERMISSIONS:
            LOGIN ${config}.data.vk.login
            PASSWORD ${config}.data.vk.password

        EDIT:
            TITLE ${project}.name
            DESCRIPTION ""
            ALBUMS album_name1,album_name2
        SHARE: 
            SEND ${publisher}.friends.get(friend => friend.name = "Valentin")
                EDIT:
                    MESSAGE: "Я крутой"